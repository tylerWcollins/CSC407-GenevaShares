using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GenevaShares.Models
{
    public class Like
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public Posting Posting { get; set; }
    }
}