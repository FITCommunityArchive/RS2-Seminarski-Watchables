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

        private static Random random = new Random();

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
    
        public void ChangeProductNotification(Database.Products product, string content, string type, decimal oldPrice, decimal newPrice) {

           var orderProducts = _context.OrderProducts.ToList();
           bool hasOrderes = false;
           foreach(var orderProduct in orderProducts) {
                if (orderProduct.ProductId == product.ProductId) {
                    hasOrderes = true;
                    break;
                }
           }

            Database.Notifications notification = new Notifications() {
                Content=content,
                Type=type,
                Created=DateTime.Now
            };
            if (hasOrderes) {
                _context.Notifications.Add(notification);
                _context.SaveChanges();
            }

            foreach(var orderProduct in orderProducts) {
                if(orderProduct.ProductId == product.ProductId) {
                    var order = _context.Orders.Find(orderProduct.OrderId);
                    order.Total -= oldPrice;
                    order.Total += newPrice;
                    Database.UsersNotifications not = new UsersNotifications() {
                        Notification=notification, 
                        UserId=order.UserId
                    };
                    _context.UsersNotifications.Add(not);
                    _context.SaveChanges();
                }
            }
        }

        public void ChangeSubscriptionNotification(Database.Subscriptions subscription, string content, string type) {

            var usersSubscriptions = _context.UsersSubscriptions.ToList();
            bool hasUsers = false;
            foreach(var userSubscripion in usersSubscriptions) {
                if(userSubscripion.SubscriptionId == subscription.SubscriptionId) {
                    hasUsers = true;
                    break;
                }
            }

            Database.Notifications notification = new Notifications() {
                Content=content, 
                Type=type, 
                Created=DateTime.Now
            };

            if (hasUsers) {
                _context.Notifications.Add(notification);
                _context.SaveChanges();
            }
            foreach (var userSubscripion in usersSubscriptions) {
                if(userSubscripion.SubscriptionId == subscription.SubscriptionId) {
                    Database.UsersNotifications not = new UsersNotifications() { 
                        Notification=notification, 
                        UserId=userSubscripion.UserId
                    };
                    _context.UsersNotifications.Add(not);
                    _context.SaveChanges();
                }
            }
        }

        public void ChangeRotationNotification(Database.Rotations rotation, string content, string type) {

            var usersRotations = _context.UsersRotations.ToList();
            bool hasUsers = false;
            foreach (var userRotation in usersRotations) {
                if (userRotation.RotationId == rotation.RotationId) {
                    hasUsers = true;
                    break;
                }
            }

            Database.Notifications notification = new Notifications() {
                Content = content,
                Type = type,
                Created = DateTime.Now
            };

            if (hasUsers) {
                _context.Notifications.Add(notification);
                _context.SaveChanges();
            }
            foreach (var userRotation in usersRotations) {
                if (userRotation.RotationId == rotation.RotationId) {
                    Database.UsersNotifications not = new UsersNotifications() {
                        Notification = notification,
                        UserId = userRotation.UserId
                    };
                    _context.UsersNotifications.Add(not);
                    _context.SaveChanges();
                }
            }
        }

        public void DeleteAppointmentsNotification(List<Database.Appointments> apps, string content, string type) {
            
            var orders = _context.Orders.ToList();
            var tickets = _context.Tickets.ToList();
            var orderProducts = _context.OrderProducts.ToList();
            bool hasOrders = false;

            foreach(var app in apps) {
                foreach(var order in orders) {
                    if (order.AppointmentId == app.AppointmentId) {
                        hasOrders = true;
                        break;
                    }
                }
                if (hasOrders) break;
            }

            Database.Notifications notification = new Notifications() {
                Content = content,
                Type=type, 
                Created=DateTime.Now
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
                        foreach(var ticket in tickets) {
                            if(ticket.OrderId == order.OrderId) {
                                _context.Tickets.Remove(ticket);
                                _context.SaveChanges();
                            }
                        }
                        foreach(var orderProduct in orderProducts) {
                            if(orderProduct.OrderId == order.OrderId) {
                                _context.OrderProducts.Remove(orderProduct);
                                _context.SaveChanges();
                            }
                        }
                        _context.Orders.Remove(order);
                        _context.SaveChanges();
                    }
                }
                _context.Appointments.Remove(app);
            }
        }

        public void DeleteCdmsNotification(List<Database.CinemaDayMovie> cdms, string content, string type) {

            List<Database.Appointments> apps = new List<Appointments>();
            foreach(var cdm in cdms) {
                foreach(var app in _context.Appointments.ToList()) {
                    if(app.CinemaDayMovieId == cdm.CinemaDayMovieId) {
                        apps.Add(app);
                    }
                }
            }
            this.DeleteAppointmentsNotification(apps, content, type);
            foreach(var cdm in cdms) {
                _context.CinemaDayMovie.Remove(cdm);
                _context.SaveChanges();
            }

        }

        public void DeleteProductNotification(Database.Products product, string content, string type) {

            var orderProducts = _context.OrderProducts.ToList();
            bool hasOrders = false;

            foreach(var orderProduct in orderProducts) {
                if (orderProduct.ProductId == product.ProductId) {
                    hasOrders = true;
                    break;
                }
            }

            Database.Notifications notification = new Notifications() {
                Content = content,
                Type=type, 
                Created=DateTime.Now
            };

            if (hasOrders) {
                _context.Notifications.Add(notification);
                _context.SaveChanges();
            }

            foreach(var orderProduct in orderProducts) {
                if (orderProduct.ProductId == product.ProductId) {
                    var order = _context.Orders.Find(orderProduct.OrderId);
                    order.Total -= product.Price;
                    Database.UsersNotifications not = new UsersNotifications() {
                        Notification = notification,
                        UserId = order.UserId
                    };
                    _context.UsersNotifications.Add(not);
                    _context.OrderProducts.Remove(orderProduct);
                    _context.SaveChanges();
                }
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public void DeleteSubscriptionNotification(Database.Subscriptions subscription, string content, string type) {
            
            var usersSubscriptions = _context.UsersSubscriptions.ToList();
            var hasUsers = false;

            foreach(var usersSubscription in usersSubscriptions) {
                if(usersSubscription.SubscriptionId == subscription.SubscriptionId) {
                    hasUsers = true;
                    break;
                }
            }

            Database.Notifications notification = new Notifications() {
                Content = content,
                Type = type,
                Created = DateTime.Now
            };

            if (hasUsers) {
                _context.Notifications.Add(notification);
                _context.SaveChanges();
            }

            foreach (var usersSubscription in usersSubscriptions) {
                if (usersSubscription.SubscriptionId == subscription.SubscriptionId) {
                    Database.UsersNotifications not = new UsersNotifications() {
                        Notification = notification,
                        UserId = usersSubscription.UserId
                    };
                    _context.UsersNotifications.Add(not);
                    _context.UsersSubscriptions.Remove(usersSubscription);
                    _context.SaveChanges();
                }    
            }
            _context.Subscriptions.Remove(subscription);
            _context.SaveChanges();
        }

        public void DeleteRotationNotification(Database.Rotations rotation, string content, string type) {

            var usersRotations = _context.UsersRotations.ToList();
            var hasUsers = false;

            foreach (var usersRotation in usersRotations) {
                if (usersRotation.RotationId == rotation.RotationId) {
                    hasUsers = true;
                    break;
                }
            }

            Database.Notifications notification = new Notifications() {
                Content = content,
                Type = type,
                Created = DateTime.Now
            };

            var notifications = _context.Notifications.ToList();
            bool sameNot = false;
            var notId = 0;
            foreach(var n in notifications) {
                if(n.Content == content) {
                    sameNot = true;
                    notId = n.NotificationId;
                    break;
                }
            }

            if (hasUsers && !sameNot) {
                _context.Notifications.Add(notification);
                _context.SaveChanges();
            }
            

            foreach (var usersRotation in usersRotations) {
                if (usersRotation.RotationId == rotation.RotationId) {
                    Database.UsersNotifications not = new UsersNotifications() {                        
                        UserId = usersRotation.UserId
                    };
                    if (sameNot) not.NotificationId = notId;
                    else not.Notification = notification;
                    _context.UsersNotifications.Add(not);
                    _context.UsersRotations.Remove(usersRotation);
                    _context.SaveChanges();
                }
            }
            _context.Rotations.Remove(rotation);
            _context.SaveChanges();
        }

        public void DeleteShowNotification(Database.Shows show, string content, string type) {

            var usersShows = _context.UsersShows.ToList();
            var hasUsers = false;

            foreach (var usersShow in usersShows) {
                if (usersShow.ShowId == show.ShowId) {
                    hasUsers = true;
                    break;
                }
            }

            Database.Notifications notification = new Notifications() {
                Content = content,
                Type = type,
                Created = DateTime.Now
            };

            if (hasUsers) {
                _context.Notifications.Add(notification);
                _context.SaveChanges();
            }

            foreach (var usersShow in usersShows) {
                if (usersShow.ShowId == show.ShowId) {
                    Database.UsersNotifications not = new UsersNotifications() {
                        Notification = notification,
                        UserId = usersShow.UserId
                    };
                    _context.UsersNotifications.Add(not);
                    _context.UsersShows.Remove(usersShow);
                    _context.SaveChanges();
                }
            }

            var rotations = _context.Rotations.ToList();
            foreach(var rotation in rotations) {
                if(rotation.ShowId == show.ShowId) {
                    this.DeleteRotationNotification(rotation, $"Rotations with the show '{show.Title}' have been removed", "Removal");
                }
            }


            _context.Shows.Remove(show);
            _context.SaveChanges();
        }

        public void DeleteMovieNotification(Database.Movies movie, string content, string type) {

            var cdms = _context.CinemaDayMovie.Where(cdm => cdm.MovieId == movie.MovieId).ToList();
            this.DeleteCdmsNotification(cdms, $"Cinema appointments for the movie '{movie.Title}' have been removed", "Removal");


            var usersMovies = _context.UsersMovies.ToList();
            var hasUsers = false;

            foreach (var userMovie in usersMovies) {
                if (userMovie.MovieId == movie.MovieId) {
                    hasUsers = true;
                    break;
                }
            }

            Database.Notifications notification = new Notifications() {
                Content = content,
                Type = type,
                Created = DateTime.Now
            };

            if (hasUsers) {
                _context.Notifications.Add(notification);
                _context.SaveChanges();
            }

            foreach (var userMovie in usersMovies) {
                if (userMovie.MovieId == movie.MovieId) {
                    Database.UsersNotifications not = new UsersNotifications() {
                        Notification = notification,
                        UserId = userMovie.UserId
                    };
                    _context.UsersNotifications.Add(not);
                    _context.UsersMovies.Remove(userMovie);
                    _context.SaveChanges();
                }
            }

            var rotations = _context.Rotations.ToList();
            foreach (var rotation in rotations) {
                if (rotation.MovieId == movie.MovieId) {
                    this.DeleteRotationNotification(rotation, $"Rotations with the movie '{movie.Title}' have been removed", "Removal");
                }
            }

            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public void DeleteOrderNotification(int orderId, string content, string type) {
            Database.Notifications notification = new Notifications() {
                Content = content,
                Created = DateTime.Now,
                Type = type
            };
            _context.Notifications.Add(notification);
            _context.SaveChanges();

            var order = _context.Orders.Find(orderId);
            Database.UsersNotifications not = new UsersNotifications() {
                Notification = notification,
                UserId = order.UserId
            };
            _context.UsersNotifications.Add(not);
            _context.SaveChanges();

            foreach(var ticket in _context.Tickets.ToList()) {
                if (ticket.OrderId == order.OrderId) {
                    _context.Tickets.Remove(ticket);
                    _context.SaveChanges();
                }
            }

            foreach(var orderProduct in _context.OrderProducts.ToList()) {
                if(orderProduct.OrderId == order.OrderId) {
                    _context.OrderProducts.Remove(orderProduct);
                    _context.SaveChanges();
                }
            }

            _context.Orders.Remove(order);
            _context.SaveChanges();
        }

        public string RandomString(int length) {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
