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
            daño = game.calculateDamage("Hierba", "Hierba", 240, 240);

            Assert.AreEqual(50, daño);
        }

        [TestMethod]
        public void TestNormalDamage()
        {
            daño = game.calculateDamage("Hierba", "Hierba", 240, 120);

            Assert.AreEqual(100, daño);
        }

        [TestMethod]
        public void TestEffectiveDamage()
        {
            daño = game.calculateDamage("Fuego", "Hierba", 240, 120);

            Assert.AreEqual(200, daño);
        }

    }
}
