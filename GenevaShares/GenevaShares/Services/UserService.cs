using GenevaShares.Data;
using GenevaShares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenevaShares.Services
{
    public class UserService : IUserService
    {

        private GenevaSharesDbContext context;
        private IEncryptor encryptor;
        public UserService(IEncryptor encryptor)
        {
            this.encryptor = encryptor;
            this.context = new GenevaSharesDbContext();
        }


        public bool Authenticate(string username, string password)
        {
            return true;
        }


        public void Register(User user)
        {
            user.Password = this.encryptor.Encrypt(user.Password);

            this.context.Users.Add(user);
            this.context.SaveChanges();
        }
    }
}