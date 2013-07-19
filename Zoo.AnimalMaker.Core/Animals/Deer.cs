
namespace Zoo.AnimalMaker.Core.Animals
{
    /// <summary>
    /// The deer.
    /// </summary>
    public class Deer : AnimalBase
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Deer"/> class.
        /// </summary>
        public Deer()
            : base(10)
        {
            this.TypeName = "Mammals";
            this.NumberOfLegs = 4;
        }

        #endregion
    }
}