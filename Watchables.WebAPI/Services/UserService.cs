using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.Model;
using Watchables.Model.Requests;
using Watchables.WebAPI.Database;

namespace Watchables.WebAPI.Services
{
    public class UserService : IUserService
    {

        //Dependency injection 
        private readonly _160304Context _context;
        private readonly IMapper _mapper;
        private readonly IAccountService _accoutnService;
        public UserService(_160304Context context, IMapper mapper, IAccountService accountService) {
            _context = context;
            _mapper = mapper;
            _accoutnService = accountService;
        }

        public List<Model.User> Get(Model.Requests.UserSearchRequest request) {

            var query = _context.Users.Include(u=>u.Account).AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.FirstName)) query = query.Where(m => m.FirstName.ToLower().StartsWith(request.FirstName.ToLower()));
            if (!string.IsNullOrWhiteSpace(request.LastName)) query = query.Where(m => m.LastName.ToLower().StartsWith(request.LastName.ToLower()));
            if (!string.IsNullOrWhiteSpace(request.Userneme)) query = query.Where(m => m.Account.Username.ToLower().StartsWith(request.Userneme.ToLower()));

            return _mapper.Map<List<Model.User>>(query.ToList());
        }

        public User GetById(int id) {
            return _mapper.Map<Model.User>(_context.Users.Include(u => u.Account).Single(u=>u.UserId==id));
        }

        public Model.User Insert(InsertUserRequest request) {

            var user = _mapper.Map<Database.Users>(request);

            request.Role = Role.Korisnik;
            var accountId = _accoutnService.Insert(request).AccountId;

            user.AccountId = accountId;
            user.Locked = false;

            _context.Users.Add(user);
            _context.SaveChanges();

            return _mapper.Map<Model.User>(user);
        }

        public string LockToggle(bool flag) {
            foreach (var user in _context.Users.ToList()) user.Locked = flag;
            _context.SaveChanges();
            if (flag) return "Users are locked";
            else return "Users are unlocked";
        }

        public User Update(int userId, InsertUserRequest request) {
            var user = _context.Users.Find(userId);
            _mapper.Map(request, user);
            _context.SaveChanges();

            _accoutnService.Update(user.AccountId, request);


            return _mapper.Map<Model.User>(user);
        }
    }
}
