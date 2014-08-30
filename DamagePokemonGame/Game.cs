using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamagePokemonGame
{
    public class Game
    {
        static void Main(string[] args)
        {
        }

        public double calculateEffectiveness(string attack, string deffender)
        {
            double effectiveness = 0;
            switch (attack)
            {
                case "Fuego":
                    switch (deffender)
                    {
                        case "Fuego":
                            effectiveness = 1;
                            break;
                        case "Agua":
                            effectiveness = 0.5;
                            break;
                        case "Hierba":
                            effectiveness = 2;
                            break;
                        case "Eléctrico":
                            effectiveness = 1;
                            break;
                        default:
                            effectiveness = 0;
                            break;
                    }
                    break;
                case "Hierba":
                    switch (deffender)
                    {
                        case "Fuego":
                            effectiveness = 0.5;
                            break;
                        case "Agua":
                            effectiveness = 2;
                            break;
                        case "Hierba":
                            effectiveness = 1;
                            break;
                        case "Eléctrico":
                            effectiveness = 1;
                            break;
                        default:
                            effectiveness = 0;
                            break;
                    }
                    break;
                case "Agua":
                    switch (deffender)
                    {
                        case "Fuego":
                            effectiveness = 2;
                            break;
                        case "Agua":
                            effectiveness = 1;
                            break;
                        case "Hierba":
                            effectiveness = 0.5;
                            break;
                        case "Eléctrico":
                            effectiveness = 0.5;
                            break;
                        default:
                            effectiveness = 0;
                            break;
                    }
                    break;
                case "Eléctrico":
                    switch (deffender)
                    {
                        case "Fuego":
                            effectiveness = 1;
                            break;
                        case "Agua":
                            effectiveness = 2;
                            break;
                        case "Hierba":
                            effectiveness = 1;
                            break;
                        case "Eléctrico":
                            effectiveness = 1;
                            break;
                        default:
                            effectiveness = 0;
                            break;
                    }
                    break;
                default:
                    effectiveness = 0;
                    break;
            }
            return effectiveness;
        }

        public int calculateDamage(string attackType, string deffenderType, int attack, int defense)
        {
            double effectiveness = calculateEffectiveness(attackType, deffenderType);
            double damage = 50 * (attack / defense) * effectiveness;

            return (int)damage;
        }
    }
}
