using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenevaShares.Services
{
    public interface IEncryptor
    {
        string Encrypt(string input);
    }
}