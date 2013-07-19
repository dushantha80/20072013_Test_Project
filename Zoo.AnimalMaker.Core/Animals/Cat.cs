
namespace Zoo.AnimalMaker.Core.Animals
{
    /// <summary>
    /// The cat.
    /// </summary>
    public class Cat : AnimalBase
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Cat"/> class.
        /// </summary>
        public Cat()
            : base(10)
        {
            this.TypeName = "Mammals";
            this.NumberOfLegs = 4;
        }

        #endregion
    }
}