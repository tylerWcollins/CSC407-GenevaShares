using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenevaShares.Services
{
    public interface IUserService
    {
        bool Authenticate(string uername, string password);
    }
}
