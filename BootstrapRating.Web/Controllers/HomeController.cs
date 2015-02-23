using BootstrapRating.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapRating.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new SampleViewModel { Value = 3 });
        }

        [HttpPost]
        public ActionResult HtmlPost(SampleViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Message = string.Format("Post new value = {0}", model.Value);
            }
            return View("Index", model);
        }

        [HttpPost]
        public ActionResult AjaxPost(SampleViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Content(string.Format("Post (Ajax) new value = {0}", model.Value));
            }
            return Content("Invalid model!");
        }
    }
}