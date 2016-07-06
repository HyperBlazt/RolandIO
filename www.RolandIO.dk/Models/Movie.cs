using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace www.RolandIO.dk.Models
{
    /// <summary>
    /// The movie.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public int Type { get; set; }
    }
}