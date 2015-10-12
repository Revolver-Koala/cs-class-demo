namespace RPGBattleDemo
{
    partial class FrmBattle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.grpPlayer = new System.Windows.Forms.GroupBox();
            this.txtPlayerHP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlayerAtk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMonsterA = new System.Windows.Forms.GroupBox();
            this.txtMonsterHpA = new System.Windows.Forms.TextBox();
            this.txtMonsterNameA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonsterAtkA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFight = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.grpPlayer.SuspendLayout();
            this.grpMonsterA.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(68, 20);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.ReadOnly = true;
            this.txtPlayerName.Size = new System.Drawing.Size(132, 22);
            this.txtPlayerName.TabIndex = 1;
            // 
            // grpPlayer
            // 
            this.grpPlayer.Controls.Add(this.txtPlayerHP);
            this.grpPlayer.Controls.Add(this.label3);
            this.grpPlayer.Controls.Add(this.txtPlayerAtk);
            this.grpPlayer.Controls.Add(this.label2);
            this.grpPlayer.Controls.Add(this.label1);
            this.grpPlayer.Controls.Add(this.txtPlayerName);
            this.grpPlayer.Location = new System.Drawing.Point(17, 16);
            this.grpPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPlayer.Name = "grpPlayer";
            this.grpPlayer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPlayer.Size = new System.Drawing.Size(260, 133);
            this.grpPlayer.TabIndex = 2;
            this.grpPlayer.TabStop = false;
            this.grpPlayer.Text = "Player";
            // 
            // txtPlayerHP
            // 
            this.txtPlayerHP.Location = new System.Drawing.Point(69, 53);
            this.txtPlayerHP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlayerHP.Name = "txtPlayerHP";
            this.txtPlayerHP.ReadOnly = true;
            this.txtPlayerHP.Size = new System.Drawing.Size(47, 22);
            this.txtPlayerHP.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "HP:";
            // 
            // txtPlayerAtk
            // 
            this.txtPlayerAtk.Location = new System.Drawing.Point(68, 85);
            this.txtPlayerAtk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlayerAtk.Name = "txtPlayerAtk";
            this.txtPlayerAtk.ReadOnly = true;
            this.txtPlayerAtk.Size = new System.Drawing.Size(48, 22);
            this.txtPlayerAtk.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Attack:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // grpMonsterA
            // 
            this.grpMonsterA.Controls.Add(this.txtMonsterHpA);
            this.grpMonsterA.Controls.Add(this.txtMonsterNameA);
            this.grpMonsterA.Controls.Add(this.label4);
            this.grpMonsterA.Controls.Add(this.label6);
            this.grpMonsterA.Controls.Add(this.txtMonsterAtkA);
            this.grpMonsterA.Controls.Add(this.label5);
            this.grpMonsterA.Location = new System.Drawing.Point(285, 16);
            this.grpMonsterA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMonsterA.Name = "grpMonsterA";
            this.grpMonsterA.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMonsterA.Size = new System.Drawing.Size(267, 133);
            this.grpMonsterA.TabIndex = 3;
            this.grpMonsterA.TabStop = false;
            this.grpMonsterA.Text = "Monster";
            // 
            // txtMonsterHpA
            // 
            this.txtMonsterHpA.Location = new System.Drawing.Point(72, 53);
            this.txtMonsterHpA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonsterHpA.Name = "txtMonsterHpA";
            this.txtMonsterHpA.ReadOnly = true;
            this.txtMonsterHpA.Size = new System.Drawing.Size(47, 22);
            this.txtMonsterHpA.TabIndex = 12;
            // 
            // txtMonsterNameA
            // 
            this.txtMonsterNameA.Location = new System.Drawing.Point(71, 20);
            this.txtMonsterNameA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonsterNameA.Name = "txtMonsterNameA";
            this.txtMonsterNameA.ReadOnly = true;
            this.txtMonsterNameA.Size = new System.Drawing.Size(132, 22);
            this.txtMonsterNameA.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "HP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Name:";
            // 
            // txtMonsterAtkA
            // 
            this.txtMonsterAtkA.Location = new System.Drawing.Point(71, 85);
            this.txtMonsterAtkA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonsterAtkA.Name = "txtMonsterAtkA";
            this.txtMonsterAtkA.ReadOnly = true;
            this.txtMonsterAtkA.Size = new System.Drawing.Size(48, 22);
            this.txtMonsterAtkA.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Attack:";
            // 
            // btnFight
            // 
            this.btnFight.Location = new System.Drawing.Point(232, 156);
            this.btnFight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(100, 28);
            this.btnFight.TabIndex = 4;
            this.btnFight.Text = "Fight!";
            this.btnFight.UseVisualStyleBackColor = true;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(17, 208);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(533, 51);
            this.txtStatus.TabIndex = 5;
            // 
            // FrmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 278);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnFight);
            this.Controls.Add(this.grpMonsterA);
            this.Controls.Add(this.grpPlayer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBattle";
            this.Text = "Battle";
            this.grpPlayer.ResumeLayout(false);
            this.grpPlayer.PerformLayout();
            this.grpMonsterA.ResumeLayout(false);
            this.grpMonsterA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.GroupBox grpPlayer;
        private System.Windows.Forms.TextBox txtPlayerHP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlayerAtk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpMonsterA;
        private System.Windows.Forms.TextBox txtMonsterHpA;
        private System.Windows.Forms.TextBox txtMonsterNameA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonsterAtkA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.TextBox txtStatus;
    }
}

