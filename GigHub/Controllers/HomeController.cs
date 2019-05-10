using GigHub.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
namespace GigHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            //var upcomingGigs = _context.Gigs.Include(w => w).Where(w => w.DateTime > DateTime.Now).ToList();
            var upcomingGigs = _context.Gigs.Include(w => w.Artist).Where(w => w.DateTime > DateTime.Now);
            return View(upcomingGigs);
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
    }
}