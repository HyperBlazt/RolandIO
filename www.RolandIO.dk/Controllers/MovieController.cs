using System.Web.Mvc;

namespace www.RolandIO.dk.Controllers
{
    using Models;

    /// <summary>
    /// The movie controller.
    /// </summary>
    public class MovieController : Controller
    {
        // GET: Movie

        /// <summary>
        /// The random.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek", Id = 1 };

            return View(movie);
        }
    }
}