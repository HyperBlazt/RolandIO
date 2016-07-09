// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MovieController.cs" company="rolandio">
//   2016-07
// </copyright>
// <summary>
//   The movie controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace www.RolandIO.dk.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;

    using Models;

    using ViewModels;

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
            var movie = new Movie { Name = "Shrek", Id = 1 };
            var customer = new List<Customer>
                               {
                                   new Customer { CustomerName = "Torben" },
                                   new Customer { CustomerName = "Preben" }
                               };
            var viewModel = new RandomMovieViewModel
                                {
                                    Movie = movie,
                                    Customers = customer
                                };
            return View(viewModel);
        }

        /// <summary>
        /// The edit.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

        /// <summary>
        /// The index.
        /// </summary>
        /// <param name="pageIndex">
        /// The page index.
        /// </param>
        /// <param name="sortBy">
        /// The sort by.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            return null;
        }

        /// <summary>
        /// The release by year.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        [Route("movie/released/{year}/{month:regex(\\d{2})}")]
        public ActionResult ReleaseByYear()
        {
            return Content("Test");
        }
    }
}