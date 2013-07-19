
namespace Zoo.AnimalMaker.Core
{
    #region Namespace Imports

    using Zoo.AnimalMaker.Core.Animals;
    using Zoo.AnimalMaker.Core.Enumerators;

    #endregion

    /// <summary>
    /// The maker.
    /// </summary>
    public class Maker : IMaker
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
        public IAnimal CarnivoreMaker(CarnivoreAnimal carnivoreAnimal)
        {
            switch (carnivoreAnimal)
            {
                case CarnivoreAnimal.Dog:
                    return new Dog();
                case CarnivoreAnimal.Cat:
                    return new Cat();
                case CarnivoreAnimal.Crow:
                    return new Crow();
                default:
                    return null;
            }
        }

        /// <summary>
        /// Decides which animal to make.
        /// </summary>
        /// <param name="herbivoreAnimal">
        /// The herbivore Animal.
        /// </param>
        /// <returns>
        /// The <see cref="IAnimal"/>.
        /// </returns>
        public IAnimal HerbivoreMaker(HerbivoreAnimal herbivoreAnimal)
        {
            switch (herbivoreAnimal)
            {
                case HerbivoreAnimal.Deer:
                    return new Deer();
                case HerbivoreAnimal.Rabbit:
                    return new Rabbit();
                default:
                    return null;
            }
        }

        #endregion
    }
}