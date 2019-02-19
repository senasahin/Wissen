using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wissen.Model;
using Wissen.Service;

namespace Wissen.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
<<<<<<< HEAD
=======
        // GET: Category
>>>>>>> ea864b23c481a57cccfc58da7afa2b708e1a67f6
        public ActionResult Index()
        {
            var categories = categoryService.GetAll();
            return View(categories);
        }
<<<<<<< HEAD
        /**/
=======

>>>>>>> ea864b23c481a57cccfc58da7afa2b708e1a67f6
        public ActionResult Create()
        {
            var category = new Category();
            return View(category);
        }
<<<<<<< HEAD
=======


>>>>>>> ea864b23c481a57cccfc58da7afa2b708e1a67f6
        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                categoryService.Insert(category);
<<<<<<< HEAD
                //geriye basınca sayfaya donmek için redirecttoaction
=======
>>>>>>> ea864b23c481a57cccfc58da7afa2b708e1a67f6
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var category = categoryService.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }
<<<<<<< HEAD
=======

>>>>>>> ea864b23c481a57cccfc58da7afa2b708e1a67f6
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                var model = categoryService.Find(category.Id);
                model.Name = category.Name;
                model.Description = category.Description;
                categoryService.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
<<<<<<< HEAD
            categoryService.Delete(id);          
            return RedirectToAction("Index");
        }
        
    }
}
=======
            categoryService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}

>>>>>>> ea864b23c481a57cccfc58da7afa2b708e1a67f6
