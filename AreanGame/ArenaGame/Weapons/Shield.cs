using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Shield : IWeapon
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
        
        public void Strengthen(double blockingPower) {
            BlockingPower += blockingPower;
        }
    }
}
