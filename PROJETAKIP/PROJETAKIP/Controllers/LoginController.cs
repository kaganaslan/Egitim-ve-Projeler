using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using PROJETAKIP.Models.DataContext;
using PROJETAKIP.Models.Personel;

namespace PROJETAKIP.Controllers
{
    public class LoginController : Controller
    {
        private ProjeTakipDBContext db = new ProjeTakipDBContext();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(PersonelBilgileri user)
        {
            var bilgiler = db.PersonelBilgileris.FirstOrDefault(x => x.AdSoyad == user.AdSoyad && x.Sifre == user.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.AdSoyad, false);
                Session["Kullanici"] = bilgiler.AdSoyad.ToString();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid username or password";
                return View();
            }
        }

        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(PersonelBilgileri newUser)
        {
            if (ModelState.IsValid)
            {
                db.PersonelBilgileris.Add(newUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newUser);
        }

        public ActionResult Logout()
        {
            Session["Kullanici"] = null;
            Session.Abandon();
            return RedirectToAction("Index");
        }
    }
}
