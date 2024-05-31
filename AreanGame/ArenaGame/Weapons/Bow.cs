using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Bow : ISpecialWeapon
    {
        private double attackDamage;

        public int Arrows { get; set; }

        public string Name { get; set; }

        public double AttackDamage 
        { 
            get 
            {
                if (Arrows > 0)
                {
                    Arrows--;
                    return attackDamage;
                }
                return 0;
            }
            private set 
            {
                attackDamage = value;
            } 
        }

        public double BlockingPower { get; private set; }


        public Bow(string name)
        {
            Name = name;
            AttackDamage = 20;
            BlockingPower = 10;
        }

        public void ActivateSpecialPower() {
            Arrows += 2;
        }
        
    }
}
