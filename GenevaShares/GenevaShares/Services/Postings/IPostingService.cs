using GenevaShares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenevaShares.Services
{
    public interface IPostingService
    {
        List<Posting> GetPostings();

        Posting GetPostingById(int id);

        void SavePosting(Posting posting);

        void DeletePosting(int id);

        void LikePosting(int id, string username);

    }
}