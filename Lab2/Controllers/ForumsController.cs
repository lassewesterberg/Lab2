using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2.Models.Entities;
using Lab2.Models.Repositories;
using Lab2.ViewModels;
using Lab2.Models.SessionManager;

namespace Lab2.Controllers
{
    public class ForumsController : Controller
    {
        //
        // GET: /Forums/

        public ActionResult Index()
        {
            List<ForumThread> Threads = Repository.Instance.GetSortedThreads();

            return View(Threads);
        }

        public ActionResult Thread(Guid id)
        {
            ThreadViewModel vm = new ThreadViewModel();
            vm.ForumThread = Repository.Instance.Get<ForumThread>(id);
            vm.Posts = Repository.Instance.GetPostsByThreadID(id);
            return View(vm);
        }

        public ActionResult CreatePost()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatePost(Guid id, Post post)
        {
            return View();
        }



    }
}
