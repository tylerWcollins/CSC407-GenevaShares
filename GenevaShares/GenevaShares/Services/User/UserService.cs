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
        private GenevaSharesContext context;
        private IEncryptor encryptor;

        public UserService(IEncryptor encryptor)
        {
            this.context = new GenevaSharesContext();
            this.encryptor = encryptor;
        }


        public bool Authenticate(string username, string password)
        {
            var encryptedPassword = this.encryptor.Encrypt(password);
            var user = this.context.Users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == encryptedPassword).SingleOrDefault();

            return (user != null) ? true : false;
        }

        public void Register(User user)
        {
            user.Password = encryptor.Encrypt(user.Password);
            this.context.Users.Add(user);
            this.context.SaveChanges();
        }

        public bool Exists(string username)
        {
            var users = this.context.Users.Where(x => x.Username.ToLower() == username.ToLower()).ToList();

            return (users.Count == 0) ? false : true;
        }
    }
}