using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.WebAPI.Database;

namespace Watchables.WebAPI.Services
{
    public class InitializeService : IInitializeService
    {
        //Dependency injection
        private readonly _160304Context _context;
        public InitializeService (_160304Context context) {
            _context = context;
        }

        public string AddDays() {

            if (!_context.AiringDays.Any()) {
                var monday = new AiringDays() {
                    Name = "Monday",
                    StartsAt = "09:00",
                    EndsAt = "23:30"
                };
                var tuesday = new AiringDays() {
                    Name = "Tuesday",
                    StartsAt = "09:00",
                    EndsAt = "23:30"
                };
                var wednesday = new AiringDays() {
                    Name = "Wednesday",
                    StartsAt = "09:00",
                    EndsAt = "23:30"
                };
                var thursday = new AiringDays() {
                    Name = "Thursday",
                    StartsAt = "09:00",
                    EndsAt = "23:30"
                };
                var friday = new AiringDays() {
                    Name = "Firday",
                    StartsAt = "09:00",
                    EndsAt = "23:30"
                };
                var saturday = new AiringDays() {
                    Name = "Saturday",
                    StartsAt = "09:00",
                    EndsAt = "00:00"
                };
                var sunday = new AiringDays() {
                    Name = "Sunday",
                    StartsAt = "11:00",
                    EndsAt = "23:00"
                };
                _context.AiringDays.AddRange(monday, tuesday, wednesday, thursday, friday, saturday, sunday);
                _context.SaveChanges();
                return "Initialized";
            }

            else return "The database is already initialized!";
        }
    }
}
