using LINQqueries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LINQqueries.Controllers
{
    public class linkController : Controller
    {
        inrdbEntities ie = new inrdbEntities();
        // GET: link
        public ActionResult Index()
        {
            var x = from n in ie.empc select n;
            return View(x.ToList());
        }

        public ActionResult Order()
        {
            var x = from n in ie.empc orderby n.sal select n;
            return View(x.ToList());
        }


        public ActionResult Group()
        {
            var results = from p in ie.empc
                          group p.ename by p.deptno into g
                          select new Results{ Employees = g.ToList() };
            return View(results.ToList());
        }



    }
}