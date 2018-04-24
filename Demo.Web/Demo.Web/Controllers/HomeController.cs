using Demo.Web.Models;
using Demo.Web.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// get data
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GetData(Data values)
        {
            HomeService service = new HomeService();           
            var model = service.GetApiData(values);
            return PartialView("~/Views/Home/IndexData.cshtml",model);
        }
    }
}