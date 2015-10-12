using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBattleDemo
{
    class Ogre : Monster
    {
        public Ogre(string name, int hp, int attack)
            : base(name, hp, attack) { }

        public Ogre(string name) : this(name, 220, 25) { }

        public override string Attack(PlayerCharacter pl)
        {
            var damage = pl.Damaged(AttackPower);

            return this.Name + " smashed " + pl.Name +
                " with a giant club and dealt " + damage + " HP of damage!";
        }
    }
}
