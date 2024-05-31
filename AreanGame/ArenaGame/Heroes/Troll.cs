using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Troll: Hero
    {
        private double attackCount;
        private const double damageReductionCoef = 0.3;
        public Troll(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            attackCount = 0;
        }

        public override double Attack()
        {
            double damage = base.Attack();

            if (attackCount == 3)
            {
                attackCount = 0;
            }
            attackCount++;
            
            return damage - (attackCount * damageReductionCoef);
        }

        public override double Defend(double damage)
        {
            double number = random.NextDouble();
            if (number < 0.5)
            {
                damage  /= 2;
            }
            
            return base.Defend(damage);
        }
    }
}
