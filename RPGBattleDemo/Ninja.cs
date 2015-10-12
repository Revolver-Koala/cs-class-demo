using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBattleDemo
{
    class Ninja : Monster
    {
        public Ninja(string name) : this(name, 120, 15) { }

        public Ninja(string name, int hp, int attack)
            : base(name, hp, attack) { }

        public override string Attack(PlayerCharacter pl)
        {
            var damage = pl.Damaged(AttackPower);

            return this.Name + " ninja chopped " + pl.Name +
                " and dealt " + damage + " HP of damage!";
        }
    }
}
