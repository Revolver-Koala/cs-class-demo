using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBattleDemo
{
    class Monster
    {
        public string Name { get; private set; }

        public int HitPoints { get; protected set; }

        public int AttackPower { get; private set; }

        public Monster(string name, int hitPoints, int attack)
        {
            this.Name = name;
            this.HitPoints = hitPoints;
            this.AttackPower = attack;
        }

        public virtual string Damaged(int power)
        {
            HitPoints = HitPoints - power;
            return "You attacked " + this.Name +
                " and dealt " + power + " HP of damage!";
        }

        public virtual string Attack(PlayerCharacter pl)
        {
            var damage = pl.Damaged(AttackPower);

            return "The monster attacked you for " + damage + " points of damage!";
        }
            //var damage = pl.Damaged(AttackPower);
    }
}
