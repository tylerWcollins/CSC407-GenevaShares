using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenevaShares.Models
{
    public class Posting
    {
        public Posting()
        {
            this.Likes = new List<Like>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string Author { get; set; }

        public virtual ICollection<Like> Likes { get; set; }
    }
}