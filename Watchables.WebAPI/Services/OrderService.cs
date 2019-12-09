using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.Model;
using Watchables.Model.Requests;
using Watchables.WebAPI.Database;
using Watchables.WebAPI.Exceptions;

namespace Watchables.WebAPI.Services
{
    public class OrderService : BaseCRUDService<Model.Order, Model.Requests.OrderSerachRequest, Database.Orders, Model.Requests.InsertOrderRequest, Model.Requests.InsertOrderRequest>
    {
        public OrderService(_160304Context context, IMapper mapper) : base(context, mapper) {
        }

        public override Order Insert(InsertOrderRequest request) {

            
            Database.Orders order = new Orders();
            order.Total= request.NumberOfTickets * request.Appointment.Price;
            order.UserId = request.UserId;
            order.AppointmentId = request.Appointment.AppointmentId;
            foreach (var product in request.Products) {
                order.Total += product.Price;
                Database.OrderProducts newItem = new OrderProducts() {
                    Order = order,
                    ProductId = product.ProductId
                };
                _context.OrderProducts.Add(newItem);
            }
            Helper helper = new Helper(_context);
            for(var i=0; i<request.NumberOfTickets; i++) {
                Database.Tickets newTicket = new Tickets() {
                    DateTime = DateTime.Now,
                    Order = order,
                    Seat = helper.RandomString(5)
                };
                _context.Tickets.Add(newTicket);
            }

            _context.Orders.Add(order);
            _context.Appointments.Find(request.Appointment.AppointmentId).SoldSeats += request.NumberOfTickets;
            _context.SaveChanges();

            var app = _context.Appointments.Include(a => a.CinemaDayMovie).ThenInclude(cdm => cdm.Movie).Single(a => a.AppointmentId == request.Appointment.AppointmentId);
            Database.Notifications notification = new Notifications() {
                Created = DateTime.Now,
                Type = "Order",
                Content = $"{_context.Users.Find(request.UserId).FirstName} {_context.Users.Find(request.UserId).FirstName} placed an order for '{app.CinemaDayMovie.Movie.Title}' of {order.Total}"
            };
            _context.Notifications.Add(notification);
            Database.UsersNotifications not = new UsersNotifications() {
                Notification=notification, 
                UserId=request.UserId
            };
            _context.UsersNotifications.Add(not);
            _context.SaveChanges();

            return _mapper.Map<Model.Order>(order);
        }

        public override List<Order> Get(OrderSerachRequest search) {
            var query = _context.Orders.AsQueryable();
            if (search.Total > 0) query = query.Where(o => o.Total >= search.Total);
            return _mapper.Map<List<Model.Order>>(query.ToList());
        }

        public override string Delete(int id) {
            Helper helper = new Helper(_context);

            var validOrder = false;
            foreach (var o in _context.Orders.ToList()) {
                if (o.OrderId == id) {
                    validOrder = true;
                    break;
                }
            }
            if (!validOrder) throw new UserException("Cannot find an order with specified id");

            var order = _context.Orders.Include(o => o.User).Include(o=>o.Appointment).Single(o=>o.OrderId == id);
            var tickets = _context.Tickets.Where(t => t.OrderId == order.OrderId).ToList();
            order.Appointment.SoldSeats -= tickets.Count;
            helper.DeleteOrderNotification(id, $"{order.User.FirstName} {order.User.LastName} removed an order of {order.Total}", "Removal");

            return "Order removed";
        }

    }
}
