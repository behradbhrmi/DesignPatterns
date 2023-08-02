using Learning.DesignPatterns.Factory;

namespace TestProject1
{
    [TestClass]
    public class UnitTestGun
    {
        [TestMethod]
        public void Fire_With_Null_Enemy_Should_Not_Throw_Exception_Test()
        {
            var gun = new Gun("rifle", new Randomizer());
            gun.Fire(null);
        }

        [TestMethod]
        public void Fire_To_Enemy_Level_1_With_Rifle_Health_Decrement_Test()
        {
            var gun = new Gun("rifle", new MockedRandomizerAlwaysHit());
            var enemy = new Enemy(1);
            gun.Fire(enemy);
            Assert.AreEqual(120, enemy.Health);
        }
    }
}