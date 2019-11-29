using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.WebAPI.Database;
using Watchables.WebAPI.Exceptions;

namespace Watchables.WebAPI.Services
{
    public class AppointmentsService : IAppointmentsService
    {
        //Dependency injection 
        private readonly _160304Context _context;
        private readonly IMapper _mapper;
        public AppointmentsService(_160304Context context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Appointments> Get() {
            return _mapper.Map<List<Model.Appointments>>(_context.Appointments.ToList());
        }

        public Model.Appointments GetById(int id) {
            return _mapper.Map<Model.Appointments>(_context.Appointments.Find(id));
        }

        public Model.Appointments Insert(Model.Requests.InsertAppointmentRequest app) {

            bool validCinemDayMovie = false;
            foreach (var cdm in _context.CinemaDayMovie) {
                if (app.CinemaDayMovieId == cdm.CinemaDayMovieId) {
                    validCinemDayMovie = true;
                    break;
                }
            }
            if (!validCinemDayMovie) throw new UserException("Invalid cinemaDayMovieId");

            bool validHall = false;
            foreach (var hall in _context.Hall) {
                if (hall.HallId == app.HallId) {
                    validHall = true;
                    break;
                }
            }
            if (!validHall) throw new UserException("Invalid hallId");

            var appointment = _mapper.Map<Database.Appointments>(app);

            _context.Appointments.Add(appointment);
            _context.SaveChanges();
            return _mapper.Map<Model.Appointments>(appointment);
        }

        public Model.Appointments Update(int appointmentId, Model.Requests.InsertAppointmentRequest app) {

            bool validAppId = false;
            foreach (var inApp in _context.Appointments.ToList()) {
                if (appointmentId == inApp.AppointmentId) {
                    validAppId = true;
                    break;
                }
            }

            if (!validAppId) throw new UserException("Cannot find specified Appointment with that appointmentId!");

            bool validCinemDayMovie = false;
            foreach (var cdm in _context.CinemaDayMovie) {
                if (app.CinemaDayMovieId == cdm.CinemaDayMovieId) {
                    validCinemDayMovie = true;
                    break;
                }
            }
            if (!validCinemDayMovie) throw new UserException("Invalid cinemaDayMovieId");

            bool validHall = false;
            foreach (var hall in _context.Hall) {
                if (hall.HallId == app.HallId) {
                    validHall = true;
                    break;
                }
            }
            if (!validHall) throw new UserException("Invalid hallId");


            var baseAppointment = _context.Appointments.Find(appointmentId);
            var oldPrice = baseAppointment.Price;
            baseAppointment.Price = app.Price;
            baseAppointment.StartsAt = app.StartsAt;
            baseAppointment.HallId = app.HallId;
            _context.SaveChanges();

           Helper helper = new Helper(_context);
           helper.ChangeAppointmentNotification(baseAppointment, $"Appointment information changed (price: {baseAppointment.Price}, starts at: {baseAppointment.StartsAt}, hall: {_context.Hall.Find(baseAppointment.HallId).HallName} {_context.Hall.Find(baseAppointment.HallId).HallNumber})", "Warning", oldPrice, baseAppointment.Price);


            return _mapper.Map<Model.Appointments>(baseAppointment);
        }
    }
}
