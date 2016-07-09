// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RandomMovieViewModel.cs" company="rolandio">
//   2015-07
// </copyright>
// <summary>
//   The random movie view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace www.RolandIO.dk.ViewModels
{
    using System.Collections.Generic;
    using Models;

    /// <summary>
    /// The random movie view model.
    /// </summary>
    public class RandomMovieViewModel
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public Movie Movie { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public List<Customer> Customers { get; set; }

    }
}