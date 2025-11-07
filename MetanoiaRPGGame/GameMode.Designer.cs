namespace MetanoiaRPGGame
{
    partial class FormGameMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameMode));
            PauseButton = new Button();
            btnAttack = new Button();
            btnSpecial = new Button();
            labelMana = new Label();
            picPlayer = new PictureBox();
            picMonster = new PictureBox();
            pbarPlayerMana = new ProgressBar();
            pbarPlayerHP = new ProgressBar();
            pbarMonsterHP = new ProgressBar();
            labelBattleLog = new Label();
            labelPlayerName = new Label();
            labelMonsterName = new Label();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMonster).BeginInit();
            SuspendLayout();
            // 
            // PauseButton
            // 
            PauseButton.BackColor = Color.Transparent;
            PauseButton.BackgroundImage = (Image)resources.GetObject("PauseButton.BackgroundImage");
            PauseButton.BackgroundImageLayout = ImageLayout.Stretch;
            PauseButton.Location = new Point(12, 12);
            PauseButton.Name = "PauseButton";
            PauseButton.Size = new Size(42, 40);
            PauseButton.TabIndex = 1;
            PauseButton.UseVisualStyleBackColor = false;
            PauseButton.Click += PauseButton_Click;
            // 
            // btnAttack
            // 
            btnAttack.BackColor = Color.Transparent;
            btnAttack.BackgroundImageLayout = ImageLayout.Stretch;
            btnAttack.Font = new Font("Showcard Gothic", 18F);
            btnAttack.Image = (Image)resources.GetObject("btnAttack.Image");
            btnAttack.Location = new Point(246, 458);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(184, 40);
            btnAttack.TabIndex = 2;
            btnAttack.Text = "Attack ⚔️";
            btnAttack.UseVisualStyleBackColor = false;
            btnAttack.Click += btnAttack_Click;
            // 
            // btnSpecial
            // 
            btnSpecial.BackColor = Color.Transparent;
            btnSpecial.BackgroundImageLayout = ImageLayout.Stretch;
            btnSpecial.Font = new Font("Showcard Gothic", 18F);
            btnSpecial.Image = (Image)resources.GetObject("btnSpecial.Image");
            btnSpecial.Location = new Point(23, 458);
            btnSpecial.Name = "btnSpecial";
            btnSpecial.Size = new Size(184, 40);
            btnSpecial.TabIndex = 3;
            btnSpecial.Text = "Special 💥";
            btnSpecial.UseVisualStyleBackColor = false;
            btnSpecial.Click += btnSpecial_Click;
            // 
            // labelMana
            // 
            labelMana.AutoSize = true;
            labelMana.BackColor = Color.Transparent;
            labelMana.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMana.Image = (Image)resources.GetObject("labelMana.Image");
            labelMana.Location = new Point(26, 411);
            labelMana.Name = "labelMana";
            labelMana.Size = new Size(140, 30);
            labelMana.TabIndex = 4;
            labelMana.Text = "Mana: /100";
            // 
            // picPlayer
            // 
            picPlayer.BackColor = Color.Transparent;
            picPlayer.ErrorImage = null;
            picPlayer.Location = new Point(133, 159);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(168, 212);
            picPlayer.SizeMode = PictureBoxSizeMode.Zoom;
            picPlayer.TabIndex = 5;
            picPlayer.TabStop = false;
            // 
            // picMonster
            // 
            picMonster.BackColor = Color.Transparent;
            picMonster.BackgroundImageLayout = ImageLayout.Zoom;
            picMonster.ErrorImage = null;
            picMonster.InitialImage = null;
            picMonster.Location = new Point(477, 159);
            picMonster.Name = "picMonster";
            picMonster.Size = new Size(292, 212);
            picMonster.SizeMode = PictureBoxSizeMode.Zoom;
            picMonster.TabIndex = 6;
            picMonster.TabStop = false;
            // 
            // pbarPlayerMana
            // 
            pbarPlayerMana.ForeColor = Color.MidnightBlue;
            pbarPlayerMana.Location = new Point(133, 115);
            pbarPlayerMana.Name = "pbarPlayerMana";
            pbarPlayerMana.Size = new Size(168, 16);
            pbarPlayerMana.TabIndex = 7;
            // 
            // pbarPlayerHP
            // 
            pbarPlayerHP.Location = new Point(133, 137);
            pbarPlayerHP.Name = "pbarPlayerHP";
            pbarPlayerHP.Size = new Size(168, 16);
            pbarPlayerHP.TabIndex = 8;
            // 
            // pbarMonsterHP
            // 
            pbarMonsterHP.BackColor = Color.CadetBlue;
            pbarMonsterHP.ForeColor = Color.Red;
            pbarMonsterHP.Location = new Point(477, 137);
            pbarMonsterHP.Name = "pbarMonsterHP";
            pbarMonsterHP.Size = new Size(256, 16);
            pbarMonsterHP.TabIndex = 9;
            // 
            // labelBattleLog
            // 
            labelBattleLog.AutoSize = true;
            labelBattleLog.BackColor = Color.Transparent;
            labelBattleLog.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBattleLog.Image = (Image)resources.GetObject("labelBattleLog.Image");
            labelBattleLog.Location = new Point(511, 397);
            labelBattleLog.Name = "labelBattleLog";
            labelBattleLog.Size = new Size(106, 20);
            labelBattleLog.TabIndex = 10;
            labelBattleLog.Text = "Battle Log:\r\n";
            labelBattleLog.TextAlign = ContentAlignment.BottomRight;
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.BackColor = Color.Transparent;
            labelPlayerName.Font = new Font("Showcard Gothic", 12F);
            labelPlayerName.Image = (Image)resources.GetObject("labelPlayerName.Image");
            labelPlayerName.Location = new Point(111, 64);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(78, 20);
            labelPlayerName.TabIndex = 11;
            labelPlayerName.Text = "Player: ";
            // 
            // labelMonsterName
            // 
            labelMonsterName.AutoSize = true;
            labelMonsterName.BackColor = Color.Transparent;
            labelMonsterName.Font = new Font("Showcard Gothic", 12F);
            labelMonsterName.ForeColor = SystemColors.ControlText;
            labelMonsterName.Image = (Image)resources.GetObject("labelMonsterName.Image");
            labelMonsterName.Location = new Point(769, 64);
            labelMonsterName.Name = "labelMonsterName";
            labelMonsterName.Size = new Size(94, 20);
            labelMonsterName.TabIndex = 12;
            labelMonsterName.Text = "Monster: ";
            // 
            // FormGameMode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.BattleArena;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(958, 523);
            Controls.Add(picMonster);
            Controls.Add(picPlayer);
            Controls.Add(labelMonsterName);
            Controls.Add(labelPlayerName);
            Controls.Add(labelBattleLog);
            Controls.Add(pbarMonsterHP);
            Controls.Add(pbarPlayerHP);
            Controls.Add(pbarPlayerMana);
            Controls.Add(labelMana);
            Controls.Add(btnSpecial);
            Controls.Add(btnAttack);
            Controls.Add(PauseButton);
            Name = "FormGameMode";
            Text = "GameMode";
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMonster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PauseButton;
        private Button btnAttack;
        private Button btnSpecial;
        private Label labelMana;
        private PictureBox picPlayer;
        private PictureBox picMonster;
        private ProgressBar pbarPlayerMana;
        private ProgressBar pbarPlayerHP;
        private ProgressBar pbarMonsterHP;
        private Label labelBattleLog;
        private Label labelPlayerName;
        private Label labelMonsterName;
    }
}