using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wissen.Model;
using Wissen.Service;

namespace Wissen.Admin.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;
        private readonly ICategoryService categoryService;
        // GET: Post
        public PostController(IPostService postService, ICategoryService categoryService)
        {
            this.postService = postService;
            this.categoryService = categoryService;
        }
        public ActionResult Index()
        {
            var posts = postService.GetAll();
            return View(posts);
        }

        public ActionResult Create()
        {
            var post = new Post();
            ViewBag.CategoryId = new SelectList(categoryService.GetAll(), "Id", "Name");
            return View(post);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                postService.Insert(post);
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(categoryService.GetAll(), "Id", "Name", post.CategoryId);
            return View();
        }

        public ActionResult Edit(int id)
        {
            var post = postService.Find(id);
<<<<<<< HEAD
            if(post == null)
=======
            if  (post == null)
>>>>>>> ea864b23c481a57cccfc58da7afa2b708e1a67f6
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(categoryService.GetAll(), "Id", "Name", post.CategoryId);
            return View(post);
        }
<<<<<<< HEAD
=======

>>>>>>> ea864b23c481a57cccfc58da7afa2b708e1a67f6
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(Post post)
        {
<<<<<<< HEAD
            if(ModelState.IsValid)
=======
            if (ModelState.IsValid)
>>>>>>> ea864b23c481a57cccfc58da7afa2b708e1a67f6
            {
                var model = postService.Find(post.Id);
                model.Title = post.Title;
                model.Description = post.Description;
                model.CategoryId = post.CategoryId;
                postService.Update(model);
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(categoryService.GetAll(), "Id", "Name", post.CategoryId);
            return View();
        }

        public ActionResult Delete(int id)
        {
            postService.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
<<<<<<< HEAD
            var posts = postService.Find(id);
            return View(posts);
=======
            var post = postService.Find(id);
            return View(post);
>>>>>>> ea864b23c481a57cccfc58da7afa2b708e1a67f6
        }
    }
}