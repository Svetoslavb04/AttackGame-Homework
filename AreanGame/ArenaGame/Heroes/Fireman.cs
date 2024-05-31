using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Fireman: Hero
    {
        private int firesMade;
        public Fireman(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            firesMade = 0;
        }

        public override double Attack()
        {
            double number = random.NextDouble();

            if (number < 0.15)
            {
                firesMade++;
            }

            return base.Attack();
        }

        public override double Defend(double damage)
        {
            if (firesMade % 7 == 0)
            {
                damage = 0;
            }
            
            return base.Defend(damage);
        }
    }
}
