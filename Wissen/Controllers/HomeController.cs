using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Wissen.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DenemeForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DenemeForm(Wissen.Models.DenemeForm model)
        {
            if (ModelState.IsValid)
            {
                bool hasError = false;
                try {
                    // TODO: Mail gönder                    
                    throw new Exception("Maile sunucusuna ulaşılamıyor! Lütfen daha sonra tekrar deneyin.");                    
                } catch(Exception ex)
                {
                    ModelState.AddModelError("Error", ex.Message);
                    hasError = true;
                }
                if (hasError == false)
                {
                    ViewBag.Message = "Mail başarıyla gönderildi";
                }
                return View();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(string firstName, string lastName, string email, string phone, string message, string subject)
        {
            firstName = firstName.Trim();
            lastName = lastName.Trim();
            if (firstName == "")
            {
                ViewBag.Message = "Ad alanı gereklidir.";
                ViewBag.IsError = true;
                return View();
            }

            if (firstName.Length > 50)
            {
                ViewBag.Message = "Ad alanı 50 karakterden uzun olamaz.";
                ViewBag.IsError = true;
                return View();
            }

            if (lastName == "")
            {
                ViewBag.Message = "Soyad alanı gereklidir.";
                ViewBag.IsError = true;
                return View();
            }

            Regex regex = new Regex(@"^5(0[5-7]|[3-5]\d) ?\d{3} ?\d{4}$"); //
            Match match = regex.Match(phone);
            if (match.Success == false)
            {
                ViewBag.Message = "Telefon 5XX XXX XXXX biçiminde olmalıdır.";
                ViewBag.IsError = true;
                return View();
            }
                // TODO: Mail gönderme işlemi yapılacak

            ViewBag.Message = "Form başarıyla iletildi, en kısa zamanda dönüş yapacağız.";
            return View();
        }
    }
}