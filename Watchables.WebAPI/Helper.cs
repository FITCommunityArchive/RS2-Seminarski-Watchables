using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.WebAPI.Database;

namespace Watchables.WebAPI
{
    public class Helper
    {
        private readonly _160304Context _context;

        public Helper(_160304Context context) {
            _context = context;
        }
        
        public void NonDeleteNotification(List<Database.Appointments> apps, string content, string type) {

            bool hasOrders = false;
            var orders = _context.Orders.ToList();
            foreach (var app in apps) {
                foreach (var order in orders) {
                    if (order.AppointmentId == app.AppointmentId) {
                        hasOrders = true;
                        break;
                    }
                }
                if (hasOrders) break;
            }

            Database.Notifications notification = new Notifications() {
                Content = content,
                Type = type,
                Created = DateTime.Now
            };

            if (hasOrders) {
                _context.Notifications.Add(notification);
                _context.SaveChanges();
            }

            foreach(var app in apps) {
                foreach(var order in orders) {
                    if (order.AppointmentId == app.AppointmentId) {
                        Database.UsersNotifications not = new UsersNotifications() {
                            Notification=notification,
                            UserId=order.UserId
                        };
                        _context.UsersNotifications.Add(not);
                        _context.SaveChanges();
                    }
                }
            }
        } 

        public void ChangeAppointmentNotification(Database.Appointments app, string content, string type, decimal oldPrice, decimal newPrice) {

            bool hasOrder = false;
            foreach (var order in _context.Orders.ToList()) {
                if (order.AppointmentId == app.AppointmentId) {
                    hasOrder = true;
                    break;
                }
            }


             Database.Notifications notification = new Notifications() {
             Content = content,
             Type = type,
             Created=DateTime.Now
            };

            if (hasOrder) {
                _context.Notifications.Add(notification);
                _context.SaveChanges();
            }

            foreach(var order in _context.Orders.ToList()) {
                if (order.AppointmentId == app.AppointmentId) {
                    order.Total -= oldPrice;
                    order.Total += newPrice;
                    Database.UsersNotifications not = new UsersNotifications() {
                        Notification = notification,
                        UserId = order.UserId
                    };
                    _context.UsersNotifications.Add(not);
                    _context.SaveChanges();
                }
            }


        }
    }
}
