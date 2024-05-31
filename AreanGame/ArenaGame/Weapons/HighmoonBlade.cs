using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class HighmoonBlade : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public HighmoonBlade(string name)
        {
            Name = name;
            AttackDamage = 20;
            BlockingPower = 10;
        }

        public void ActivateHighMoon() {
            AttackDamage *= 2;
            BlockingPower *= 1.2;
        }
    }
}
