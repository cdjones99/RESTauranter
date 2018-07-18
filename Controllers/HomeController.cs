using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restauranter.Models;

namespace Restauranter.Controllers
{
    public class HomeController : Controller
    {
        private RestaurantContext _context;

        public HomeController(RestaurantContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("newReview")]
        public IActionResult newReview(Review newReview)
        //Be careful not to give an action parameter a name that is the same as a model property or the binder will attempt to bind to the parameter and fail.


        {
            if (ModelState.IsValid)
            {
                //review.created_at = DateTime.Now;
                _context.Add(newReview);
                _context.SaveChanges();
                Console.WriteLine("form taken");
               return RedirectToAction("Reviews");
            }
            else
            {
                Console.WriteLine("form did not accept");
                return View("Index");
            }
        }
        [HttpGet]
        [Route("Reviews")]
        public IActionResult Reviews()
        {
            List<Review> AllReviews = _context.restauranter.ToList();
            ViewBag.allreviews = AllReviews;
            return View();
        }
    }
}
