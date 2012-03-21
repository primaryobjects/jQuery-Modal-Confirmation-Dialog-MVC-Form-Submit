using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModalConfirmationDialog.Models;

namespace ModalConfirmationDialog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new Contact());
        }

        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            // Simulate processing delay.
            System.Threading.Thread.Sleep(3000);

            if (ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View();
            }
        }
    }
}
