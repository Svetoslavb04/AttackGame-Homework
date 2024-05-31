using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Shield : ISpecialWeapon
    {
        private double blockingPower;

        public int Arrows { get; set; }

        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower 
        { 
            get 
            {
                blockingPower *= 0.95;
                return blockingPower;
            }
            private set 
            {
                blockingPower = value;
            } 
        }

        public Shield(string name)
        {
            Name = name;
            AttackDamage = 2;
            BlockingPower = 100;
        }
        
        private void Strengthen(double blockingPower) {
            BlockingPower += blockingPower;
        }

         public void ActivateSpecialPower() {
            Strengthen(10);
        }
    }
}
