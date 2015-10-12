using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBattleDemo
{
    class Knight : Monster
    {
        public Knight(string name, int hp, int power)
            : base(name, hp, power) { }

        public Knight(string name)
            : this(name, 260, 40) { }

        public override string Damaged(int power)
        {
            var rand = new Random();

            if (rand.Next(100) < 25)
            {
                return this.Name + " blocked your attack with their shield!";
            }
            else
            {
                return base.Damaged(power);
            }
        }

        public override string Attack(PlayerCharacter pl)
        {
            return this.Name + " slashed you with their sword for " + pl.Damaged(this.AttackPower)
                + " points of damage!";
            //return base.Attack(pl);
        }
    }
}
