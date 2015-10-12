using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGBattleDemo
{
    public partial class FrmBattle : Form
    {
        private List<Monster> _monsters;
        private PlayerCharacter _pc;

        public FrmBattle()
        {
            InitializeComponent();

            _monsters = new List<Monster>();

            _monsters.Add(new Knight("Sir Cliffy"));

            _monsters.Add(new Ninja("Ninja 1"));

            _monsters.Add(new Ogre("Ogre 1"));

            _pc = new PlayerCharacter("Adventurer Bob", 400, 45);

            txtPlayerName.Text = _pc.Name;
            txtPlayerHP.Text = _pc.HitPoints.ToString();
            txtPlayerAtk.Text = _pc.AttackPower.ToString();

            txtMonsterNameA.Text = _monsters.First().Name;
            txtMonsterHpA.Text = _monsters.First().HitPoints.ToString();
            txtMonsterAtkA.Text = _monsters.First().AttackPower.ToString();
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            string output;

            output = _pc.Attack(_monsters.First()) + "\n"
                + _monsters.First().Attack(_pc);

            txtPlayerHP.Text = _pc.HitPoints.ToString();
            txtMonsterHpA.Text = _monsters.First().HitPoints.ToString();

            txtStatus.Text = output;
        }
    }
}
