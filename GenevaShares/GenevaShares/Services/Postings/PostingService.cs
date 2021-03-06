﻿using GenevaShares.Data;
using GenevaShares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenevaShares.Services.Postings
{
    public class PostingService : IPostingService
    {
        private GenevaSharesDbContext context;

        public PostingService()
        {
            this.context = new GenevaSharesDbContext();
        }

        public List<Posting> GetPostings()
        {
            return this.context.Postings.ToList();
        }

        public Posting GetPostingById(int id)
        {
            return this.context.Postings.Where(x => x.Id == id).SingleOrDefault();
        }

        public void SavePosting(Models.Posting posting)
        {
            this.context.Postings.Add(posting);
            this.context.SaveChanges();
        }

        public void DeletePosting(int id)
        {
            var posting = this.context.Postings.Where(x => x.Id == id).SingleOrDefault();
            this.context.Postings.Remove(posting);
            this.context.SaveChanges();
        }
    }
}