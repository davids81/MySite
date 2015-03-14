using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DavesNation.Models;

namespace DavesNation.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit(int Id)
        {
            PostEntry pe = PostRepository.GetPost(Id);
            ViewBag.PostEntry = pe;
            return View(pe);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(int Id, FormCollection form)
        {
            PostEntry pe = PostRepository.GetPost(Id);
            pe.Title = Request["PostTitle"];
            pe.Text = Request["BlogText"];

            PostRepository.SavePost(pe);

            return View();
        }



        public ActionResult EditList()
        {
            return View();
        }
    }
}