using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.Model;
using Watchables.WebAPI.Database;
using Watchables.WebAPI.Exceptions;

namespace Watchables.WebAPI.Services
{
    public class NotificationService : INotificationService
    {
        //Dependency injection
        private readonly _160304Context _context;
        private readonly IMapper _mapper;
        public NotificationService(_160304Context context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        public List<Notification> Get() {
            return _mapper.Map<List<Model.Notification>>(_context.Notifications.ToList());
        }

        public string RemoveNotification(int notificationId, int userId) {

            bool valid = false;
            foreach(var not in _context.Notifications.ToList()) {
                if(not.NotificationId == notificationId) {
                    valid = true;
                    break;
                }
            }
            if (!valid) throw new UserException("The notificaiton could not be found!");

            valid = false;
            foreach (var user in _context.Users.ToList()) {
                if (user.UserId == userId) {
                    valid = true;
                    break;
                }
            }
            if (!valid) throw new UserException("The user could not be found!");


            var remove = _context.UsersNotifications.Where(n => n.UserId == userId && n.NotificationId == notificationId).Single();

            _context.UsersNotifications.Remove(remove);
            _context.SaveChanges();
            return "Notification removed!";
        }
    }
}
