using GenevaShares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenevaShares.Services
{
    public interface IUserService
    {
        bool Authenticate(string username, string password);

        void Register(User user);

        bool Exists(string username);

    }
}
