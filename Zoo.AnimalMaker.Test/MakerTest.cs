using NUnit.Framework;
using Zoo.AnimalMaker.Core;
using Zoo.AnimalMaker.Core.Animals;
using Zoo.AnimalMaker.Core.Enumerators;

namespace Zoo.AnimalMaker.Test
{
    [TestFixture]
    public class MakerTest
    {
        [TestCase()]
        public void Maker_CarnivoreMaker_Dog_Success()
        {
            IMaker maker = new Maker();

            var dog = maker.CarnivoreMaker(CarnivoreAnimal.Dog);

            Assert.IsNotNull(dog);
            Assert.IsInstanceOf<Dog>(dog);
        }

        [TestCase()]
        public void Maker_HerbivoreMaker_Rabit_Success()
        {
            IMaker maker = new Maker();

            var rabit = maker.HerbivoreMaker(HerbivoreAnimal.Rabbit);

            Assert.IsNotNull(rabit);
            Assert.IsInstanceOf<Rabbit>(rabit);
        }

        [TestCase()]
        public void Maker_Dog_Weekly_Feed_Cost_Success()
        {
            IMaker maker = new Maker();

            var dog = maker.CarnivoreMaker(CarnivoreAnimal.Dog);

            Assert.AreEqual(105, dog.WeeklyFeedingCost());
        }

        [TestCase()]
        public void Maker_Crow_Wing_Success()
        {
            IMaker maker = new Maker();

            var crow = (Crow)maker.CarnivoreMaker(CarnivoreAnimal.Crow);

            Assert.AreEqual(2, crow.NumberOfWings);
        }
    }
}
