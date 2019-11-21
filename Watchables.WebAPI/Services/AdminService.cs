using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Watchables.Model;
using Watchables.Model.Requests;
using Watchables.WebAPI.Database;
using Watchables.WebAPI.Exceptions;

namespace Watchables.WebAPI.Services
{
    public class AdminService : IAdminService
    {
        //Dependency injection 
        private readonly _160304Context _context;
        private readonly IMapper _mapper;
        private readonly IAccountService _accoutnService;
        public AdminService(_160304Context context, IMapper mapper, IAccountService accountService) {
            _context = context;
            _mapper = mapper;
            _accoutnService = accountService;
        }


        public Admin Insert(InsertAdminRequest request) {
          
            var admin = _mapper.Map<Database.Admins>(request);

            request.Role = Role.Admin;
            var accountId = _accoutnService.Insert(request).AccountId;

            admin.AccountId = accountId;

            _context.Admins.Add(admin);
            _context.SaveChanges();

            return _mapper.Map<Model.Admin>(admin);
        }

        public List<Admin> Get() {
            return _mapper.Map<List<Model.Admin>>(_context.Admins.Include(i=>i.Account).ToList());
        }

        public Admin Update(int adminId, InsertAdminRequest request) {
            var admin = _context.Admins.Find(adminId);
            _mapper.Map(request, admin);
            _context.SaveChanges();

            _accoutnService.Update(admin.AccountId, request);


            return _mapper.Map<Model.Admin>(admin);
        }

        public Admin GetById(int id) {
            var admin = _mapper.Map<Model.Admin>(_context.Admins.Include(u => u.Account).Single(u => u.AdminId == id));
            return admin;
        }

        public string Delete(int id) {
            var admin = _context.Admins.Find(id);
            if (admin == null) return "Admin could not be found";
            var account = _context.Accounts.Single(a => a.AccountId == admin.AccountId);
            _context.Admins.Remove(admin);
            _context.Accounts.Remove(account);
            _context.SaveChanges();
            return "Admin removed";
        }
    }
}
