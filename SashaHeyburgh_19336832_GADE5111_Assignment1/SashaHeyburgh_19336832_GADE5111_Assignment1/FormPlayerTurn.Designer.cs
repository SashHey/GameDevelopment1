namespace SashaHeyburgh_19336832_GADE5111_Assignment1
{
    partial class FormPlayerTurn
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
            this.groupBlaster = new System.Windows.Forms.GroupBox();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnSpecialAttack = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblHP = new System.Windows.Forms.Label();
            this.groupOpponent = new System.Windows.Forms.GroupBox();
            this.lblOpponentHP = new System.Windows.Forms.Label();
            this.lblDragon = new System.Windows.Forms.Label();
            this.groupBattleLog = new System.Windows.Forms.GroupBox();
            this.richBattleLog = new System.Windows.Forms.RichTextBox();
            this.btnRest = new System.Windows.Forms.Button();
            this.groupBlaster.SuspendLayout();
            this.groupOpponent.SuspendLayout();
            this.groupBattleLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBlaster
            // 
            this.groupBlaster.Controls.Add(this.btnRest);
            this.groupBlaster.Controls.Add(this.btnBlock);
            this.groupBlaster.Controls.Add(this.btnSpecialAttack);
            this.groupBlaster.Controls.Add(this.btnAttack);
            this.groupBlaster.Controls.Add(this.lblHP);
            this.groupBlaster.Location = new System.Drawing.Point(26, 23);
            this.groupBlaster.Name = "groupBlaster";
            this.groupBlaster.Size = new System.Drawing.Size(233, 222);
            this.groupBlaster.TabIndex = 0;
            this.groupBlaster.TabStop = false;
            this.groupBlaster.Text = "Blaster";
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(7, 162);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(218, 49);
            this.btnBlock.TabIndex = 3;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnSpecialAttack
            // 
            this.btnSpecialAttack.Location = new System.Drawing.Point(8, 107);
            this.btnSpecialAttack.Name = "btnSpecialAttack";
            this.btnSpecialAttack.Size = new System.Drawing.Size(218, 49);
            this.btnSpecialAttack.TabIndex = 2;
            this.btnSpecialAttack.Text = "Special Attack";
            this.btnSpecialAttack.UseVisualStyleBackColor = true;
            this.btnSpecialAttack.Click += new System.EventHandler(this.btnSpecialAttack_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(8, 52);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(218, 49);
            this.btnAttack.TabIndex = 1;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(64, 17);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(69, 32);
            this.lblHP.TabIndex = 0;
            this.lblHP.Text = "HP:";
            // 
            // groupOpponent
            // 
            this.groupOpponent.Controls.Add(this.lblOpponentHP);
            this.groupOpponent.Controls.Add(this.lblDragon);
            this.groupOpponent.Location = new System.Drawing.Point(279, 75);
            this.groupOpponent.Name = "groupOpponent";
            this.groupOpponent.Size = new System.Drawing.Size(250, 100);
            this.groupOpponent.TabIndex = 1;
            this.groupOpponent.TabStop = false;
            this.groupOpponent.Text = "Opponent:";
            // 
            // lblOpponentHP
            // 
            this.lblOpponentHP.AutoSize = true;
            this.lblOpponentHP.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentHP.Location = new System.Drawing.Point(7, 64);
            this.lblOpponentHP.Name = "lblOpponentHP";
            this.lblOpponentHP.Size = new System.Drawing.Size(69, 32);
            this.lblOpponentHP.TabIndex = 4;
            this.lblOpponentHP.Text = "HP:";
            // 
            // lblDragon
            // 
            this.lblDragon.AutoSize = true;
            this.lblDragon.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDragon.Location = new System.Drawing.Point(6, 17);
            this.lblDragon.Name = "lblDragon";
            this.lblDragon.Size = new System.Drawing.Size(73, 18);
            this.lblDragon.TabIndex = 0;
            this.lblDragon.Text = "Dragon";
            // 
            // groupBattleLog
            // 
            this.groupBattleLog.Controls.Add(this.richBattleLog);
            this.groupBattleLog.Location = new System.Drawing.Point(26, 263);
            this.groupBattleLog.Name = "groupBattleLog";
            this.groupBattleLog.Size = new System.Drawing.Size(504, 175);
            this.groupBattleLog.TabIndex = 2;
            this.groupBattleLog.TabStop = false;
            this.groupBattleLog.Text = "Battle Log";
            // 
            // richBattleLog
            // 
            this.richBattleLog.Location = new System.Drawing.Point(8, 20);
            this.richBattleLog.Name = "richBattleLog";
            this.richBattleLog.Size = new System.Drawing.Size(488, 140);
            this.richBattleLog.TabIndex = 0;
            this.richBattleLog.Text = "";
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(8, 52);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(217, 159);
            this.btnRest.TabIndex = 4;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // FormPlayerTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.groupBattleLog);
            this.Controls.Add(this.groupOpponent);
            this.Controls.Add(this.groupBlaster);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormPlayerTurn";
            this.Text = "Player\'s Turn";
            this.Load += new System.EventHandler(this.FormPlayerTurn_Load);
            this.groupBlaster.ResumeLayout(false);
            this.groupBlaster.PerformLayout();
            this.groupOpponent.ResumeLayout(false);
            this.groupOpponent.PerformLayout();
            this.groupBattleLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBlaster;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnSpecialAttack;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.GroupBox groupOpponent;
        private System.Windows.Forms.Label lblOpponentHP;
        private System.Windows.Forms.Label lblDragon;
        private System.Windows.Forms.GroupBox groupBattleLog;
        private System.Windows.Forms.RichTextBox richBattleLog;
        private System.Windows.Forms.Button btnRest;
    }
}