using Ch04EX1MovieList.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ch04EX1MovieList.Controllers
{
    public class MovieControllercs : Controller
    {
        private MovieContext context {  get; set; }
        public MovieControllercs(MovieContext ctx) {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Moviecs());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var movie = context.Movies.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Moviecs movie)
        {
            if (ModelState.IsValid)
            {
                if (movie.MovieId== 0)
                    context.Movies.Add(movie);
                else
                    context.Movies.Update(movie);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (movie.MovieId == 0) ? "Add" : "Edit";
                return View(movie);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = context.Movies.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Moviecs movie)
        {
            context.Movies.Remove(movie);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }


    }
}
