
namespace Zoo.AnimalMaker.Core.Animals
{
    /// <summary>
    /// The rabbit.
    /// </summary>
    public class Rabbit : AnimalBase
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Rabbit" /> class.
        /// </summary>
        public Rabbit()
            : base(12)
        {
            this.TypeName = "Mammals";
            this.NumberOfLegs = 4;
        }

        #endregion
    }
}