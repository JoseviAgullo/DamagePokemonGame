using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DamagePokemonGame;

namespace DamagePokemonGameTest
{
    [TestClass]
    public class TestUnits
    {
        private Game game;
        private int daño = 0;

        [TestInitialize]
        public void setUp()
        {
            game = new Game();
        }

        [TestMethod]
        public void TestMinimumDamage()
        {            
            daño = game.calculateDamage("Hierba", "Fuego", 240, 240);

            Assert.AreEqual(1, daño);
        }

        [TestMethod]
        public void TestNormalDamage()
        {
            daño = game.calculateDamage("Hierba", "Fuego", 240, 120);

            Assert.AreEqual(2, daño);
        }

    }
}
