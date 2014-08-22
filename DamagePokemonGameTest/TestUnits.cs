using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DamagePokemonGame;

namespace DamagePokemonGameTest
{
    [TestClass]
    public class TestUnits
    {
        private Game game;

        [TestInitialize]
        public void setUp()
        {
            game = new Game();
        }

        [TestMethod]
        public void TestMinimumDamage()
        {            
            int daño = game.calculateDamage("Hierba", "Fuego", 240, 240);

            Assert.AreEqual(1, daño);
        }

        [TestMethod]
        public void TestNormalDamage()
        {
            int daño = game.calculateDamage("Hierba", "Fuego", 240, 120);

            Assert.AreEqual(2, daño);
        }

    }
}
