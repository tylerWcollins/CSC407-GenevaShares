using GenevaShares.Models;
using GenevaShares.Services.Postings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenevaShares.Controllers
{
    [Authorize]
    public class PostingsController : Controller
    {
        private PostingService postingService;

        public PostingsController()
        {
            this.postingService = new PostingService();
        }

        public ActionResult Index()
        {
            var postings = this.postingService.GetPostings();

            return View(postings);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Posting posting)
        {
            posting.Author = this.HttpContext.User.Identity.Name;

            this.postingService.SavePosting(posting);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var result = this.postingService.GetPostingById(id);
            return View(result);
        }
        
        public ActionResult Delete(int id)
        {
            this.postingService.DeletePosting(id);
            return RedirectToAction("Index", "Postings");

        }


    }
}