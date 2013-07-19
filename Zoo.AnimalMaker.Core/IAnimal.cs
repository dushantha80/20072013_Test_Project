
namespace Zoo.AnimalMaker.Core
{
    /// <summary>
    /// The Animal interface.
    /// </summary>
    public interface IAnimal
    {
        #region Public Properties

        /// <summary>
        /// Gets the daily feed cost.
        /// </summary>
        decimal DailyFeedCost { get; }

        /// <summary>
        /// Gets the number of legs.
        /// </summary>
        int NumberOfLegs { get; }

        /// <summary>
        /// Gets the type name.
        /// </summary>
        string TypeName { get; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The weekly feeding cost.
        /// </summary>
        /// <returns>
        /// The <see cref="decimal"/>.
        /// </returns>
        decimal WeeklyFeedingCost();

        #endregion
    }
}