using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;           
using kz2.Models;
using Arvelia.EF7.Sqlite.Repo;

namespace kz2.Controllers
{
    public class HomeController : Controller
    {
        private StoreContext ctx;
        private Repo<Subject> subjRepo;
        public HomeController(StoreContext context)
        {
            ctx = context;
            subjRepo = new Repo<Subject>(ctx);
        }
        public IActionResult Index()
        {
            if (ctx.Subjects.Count() ==0)
            {
                var subj = new Subject { };
            }
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
