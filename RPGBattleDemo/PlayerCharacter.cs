using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBattleDemo
{
    class PlayerCharacter
    {
        public string Name { get; private set; }

        public int HitPoints { get; private set; }

        public int AttackPower { get; private set; }

        public PlayerCharacter(string name, int hitPoints, int attack)
        {
            this.Name = name;
            this.HitPoints = hitPoints;
            this.AttackPower = attack;
        }

        public string Attack(Monster m)
        {
            var damage = m.Damaged(AttackPower);

            return damage;
        }

        public int Damaged(int power)
        {
            HitPoints = HitPoints - power;
            return power;
        }
    }
}
