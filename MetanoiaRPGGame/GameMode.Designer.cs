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
            labelPlayerName = new Label();
            labelMonsterName = new Label();
            LabelBattleLog = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMonster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            picPlayer.Location = new Point(113, 159);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(168, 223);
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
            picMonster.Location = new Point(571, 159);
            picMonster.Name = "picMonster";
            picMonster.Size = new Size(292, 223);
            picMonster.SizeMode = PictureBoxSizeMode.Zoom;
            picMonster.TabIndex = 6;
            picMonster.TabStop = false;
            // 
            // pbarPlayerMana
            // 
            pbarPlayerMana.ForeColor = Color.MidnightBlue;
            pbarPlayerMana.Location = new Point(111, 87);
            pbarPlayerMana.Name = "pbarPlayerMana";
            pbarPlayerMana.Size = new Size(170, 17);
            pbarPlayerMana.TabIndex = 7;
            // 
            // pbarPlayerHP
            // 
            pbarPlayerHP.Location = new Point(111, 109);
            pbarPlayerHP.Name = "pbarPlayerHP";
            pbarPlayerHP.Size = new Size(170, 17);
            pbarPlayerHP.TabIndex = 8;
            // 
            // pbarMonsterHP
            // 
            pbarMonsterHP.BackColor = Color.CadetBlue;
            pbarMonsterHP.ForeColor = Color.Red;
            pbarMonsterHP.Location = new Point(693, 109);
            pbarMonsterHP.Name = "pbarMonsterHP";
            pbarMonsterHP.Size = new Size(170, 17);
            pbarMonsterHP.TabIndex = 9;
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
            // LabelBattleLog
            // 
            LabelBattleLog.AutoSize = true;
            LabelBattleLog.BackColor = Color.Transparent;
            LabelBattleLog.Font = new Font("Showcard Gothic", 12F);
            LabelBattleLog.ForeColor = SystemColors.ControlText;
            LabelBattleLog.Image = (Image)resources.GetObject("LabelBattleLog.Image");
            LabelBattleLog.Location = new Point(533, 419);
            LabelBattleLog.Name = "LabelBattleLog";
            LabelBattleLog.Size = new Size(106, 20);
            LabelBattleLog.TabIndex = 13;
            LabelBattleLog.Text = "Battle Log:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Screenshot_2025_11_08_202919_removebg_preview;
            pictureBox1.Location = new Point(501, 401);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Showcard Gothic", 12F);
            label1.Location = new Point(65, 109);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 15;
            label1.Text = "HP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Showcard Gothic", 12F);
            label2.Location = new Point(65, 87);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 16;
            label2.Text = "MP:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(650, 106);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 17;
            label3.Text = "HP:";
            // 
            // FormGameMode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.BattleArena;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(958, 523);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picPlayer);
            Controls.Add(picMonster);
            Controls.Add(LabelBattleLog);
            Controls.Add(labelMonsterName);
            Controls.Add(labelPlayerName);
            Controls.Add(pbarMonsterHP);
            Controls.Add(pbarPlayerHP);
            Controls.Add(pbarPlayerMana);
            Controls.Add(labelMana);
            Controls.Add(btnSpecial);
            Controls.Add(btnAttack);
            Controls.Add(PauseButton);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "FormGameMode";
            Text = "GameMode";
            TransparencyKey = SystemColors.ActiveBorder;
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMonster).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label labelPlayerName;
        private Label labelMonsterName;
        private Label LabelBattleLog;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}