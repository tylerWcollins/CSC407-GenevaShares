using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GenevaShares.Models
{
    public class User
    {
        
        public int Id { get; set; }

        [Key]
        public int NewId { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email {get; set;}

        public string Nickname { get; set; }
    }
}