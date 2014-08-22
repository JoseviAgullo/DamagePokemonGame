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
        public void TestDamage()
        {            
            int daño = game.calculateDamage("Hierba", "Fuego", 2, 3);

            Assert.AreEqual(0, daño);
        }
    }
}
