
namespace Zoo.AnimalMaker.Core
{
    #region Namespace Imports

    using Zoo.AnimalMaker.Core.Enumerators;

    #endregion

    /// <summary>
    /// The Maker interface.
    /// </summary>
    public interface IMaker
    {
        #region Public Methods and Operators

        /// <summary>
        /// The carnivore maker.
        /// </summary>
        /// <param name="carnivoreAnimal">
        /// The carnivore animal.
        /// </param>
        /// <returns>
        /// The <see cref="IAnimal"/>.
        /// </returns>
        IAnimal CarnivoreMaker(CarnivoreAnimal carnivoreAnimal);

        /// <summary>
        /// The herbivore maker.
        /// </summary>
        /// <param name="herbivoreAnimal">
        /// The herbivore animal.
        /// </param>
        /// <returns>
        /// The <see cref="IAnimal"/>.
        /// </returns>
        IAnimal HerbivoreMaker(HerbivoreAnimal herbivoreAnimal);

        #endregion
    }
}