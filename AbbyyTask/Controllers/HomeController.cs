using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using AbbyyTask.Business;
using AbbyyTask.Business.Models;

namespace AbbyyTask.Controllers
{
    public class HomeController : Controller
    {
        private static FormService _formService;

        public ActionResult Index()
        {
            _formService = new FormService();
            return View();
        }

        [HttpGet]
        public JsonResult GetCardinalities()
        {
            return Json(FormService.Cardinalities, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetTypes()
        {
            return Json(FormService.Types, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public string GetJson(Form form)
        {
            return _formService.GetJson(form);
        }
    }
}