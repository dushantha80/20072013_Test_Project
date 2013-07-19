
namespace Zoo.AnimalMaker.Core.Animals
{
    /// <summary>
    ///     The dog.
    /// </summary>
    public class Dog : AnimalBase
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Dog" /> class.
        /// </summary>
        public Dog()
            : base(15)
        {
            this.TypeName = "Mammals";
            this.NumberOfLegs = 4;
        }

        #endregion
    }
}