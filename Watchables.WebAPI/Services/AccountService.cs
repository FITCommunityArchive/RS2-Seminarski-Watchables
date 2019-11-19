using AutoMapper;
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
    public class AccountService : IAccountService
    {

        //Dependency injection 
        private readonly _160304Context _context;
        private readonly IMapper _mapper;
        public AccountService(_160304Context context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }


        public static string GenerateSalt() {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password) {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public List<Model.Account> Get() {
            return _mapper.Map<List<Model.Account>>(_context.Accounts.ToList());
        }

        public Model.Account GetById(int id) {
            return _mapper.Map<Model.Account>(_context.Accounts.Find(id));
        }

        public Model.Account Insert(InsertAccountRequest request) {

            if (request.Password != request.ConfirmPassword) {
                throw new UserException("Passwords are not matching");
            }
            var account = _mapper.Map<Database.Account>(request);

            account.PasswordSalt = GenerateSalt();
            account.PasswordHash = GenerateHash(account.PasswordSalt, request.Password);

            _context.Accounts.Add(account);
            _context.SaveChanges();

            return _mapper.Map<Model.Account>(_mapper.Map<Database.Account>(account));
        }

        public Model.Account Update(int accountId, InsertAccountRequest request) {
            var account = _context.Accounts.Find(accountId);

            if (request.Username != null) {
                account.Username = request.Username;
            }
            if (request.Password != null) {
                if (request.Password != request.ConfirmPassword) {
                    throw new UserException("Passwords are not matching");
                }
                account.PasswordSalt = GenerateSalt();
                account.PasswordHash = GenerateHash(account.PasswordSalt, request.Password);
            }
            _context.SaveChanges();
            return _mapper.Map<Model.Account>(account);
        }

            public Model.Account Authenticate(string username, string pass) {
                var account = _context.Accounts.FirstOrDefault(x => x.Username == username);

                if (account != null) {
                    var newHash = GenerateHash(account.PasswordSalt, pass);

                    if (newHash == account.PasswordHash) {
                        return _mapper.Map<Model.Account>(account);
                    }
                }
                return null;
            }
        }
}
