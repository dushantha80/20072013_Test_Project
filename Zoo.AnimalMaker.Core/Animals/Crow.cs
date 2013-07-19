using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.AnimalMaker.Core.Animals
{
    /// <summary>
    /// The Crow.
    /// </summary>
    public class Crow : AnimalBase 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Crow" /> class.
        /// </summary>
        public Crow():base(37)
        {
            this.TypeName = "Bird";
            this.NumberOfLegs = 2;
            NumberOfWings = 2;
        }

        /// <summary>
        /// Gets or sets number of wings.
        /// </summary>
        public int NumberOfWings { get; set; }
    }
}
