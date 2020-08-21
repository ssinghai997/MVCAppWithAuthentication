using MovieCustomerMvcAppWithAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieCustomerMvcAppWithAuthentication.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;
        public MovieController()

        {

            _context = new ApplicationDbContext();

        }
        // GET: Movie
        public ActionResult Index1()
        {
            var movies = _context.Movies.ToList();

            return View(movies);
        }
        public ActionResult Genre(int id)
        {
            var genre = _context.Movies.SingleOrDefault(p=>p.Id==id);
            if (genre == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(genre);

            }
        }
        protected override void Dispose(bool disposing)

        {

            _context.Dispose();

        }
    }
}