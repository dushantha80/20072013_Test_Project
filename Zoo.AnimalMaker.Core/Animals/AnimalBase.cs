namespace Zoo.AnimalMaker.Core.Animals
{
    /// <summary>
    /// The animal base.
    /// </summary>
    public abstract class AnimalBase : IAnimal
    {
        #region Fields

        /// <summary>
        /// The feed cost.
        /// </summary>
        private readonly decimal feedCost;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimalBase"/> class.
        /// </summary>
        /// <param name="dailyFeedCost">
        /// The daily feed cost.
        /// </param>
        protected AnimalBase(decimal dailyFeedCost)
        {
            this.feedCost = dailyFeedCost;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the daily feed cost.
        /// </summary>
        public decimal DailyFeedCost
        {
            get
            {
                return this.feedCost;
            }
        }

        /// <summary>
        /// Gets or sets the number of legs.
        /// </summary>
        public int NumberOfLegs { get; set; }

        /// <summary>
        /// Gets or sets the type name.
        /// </summary>
        public string TypeName { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The weekly feeding cost.
        /// </summary>
        /// <returns>
        /// The <see cref="decimal"/>.
        /// </returns>
        public virtual decimal WeeklyFeedingCost()
        {
            return this.DailyFeedCost * 7;
        }

        #endregion
    }
}