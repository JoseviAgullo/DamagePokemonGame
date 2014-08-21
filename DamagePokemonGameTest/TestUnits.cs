using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DamagePokemonGame;

namespace DamagePokemonGameTest
{
    [TestClass]
    public class TestUnits
    {
        [TestMethod]
        public void TestMethod1()
        {
            Game game = new Game();

            int daño = game.calculateDamage("Hierba", "Fuego", 2, 3);
        }
    }
}
