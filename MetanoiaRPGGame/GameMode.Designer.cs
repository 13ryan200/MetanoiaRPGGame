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
            buttonSpecialAttack = new Button();
            buttonAttack = new Button();
            labelMana = new Label();
            labelBattleLog = new Label();
            labelPlayerName = new Label();
            labelMonsterName = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pbarPlayerHP = new ProgressBar();
            pbarMonsterHP = new ProgressBar();
            pbarPlayerMana = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PauseButton
            // 
            PauseButton.BackColor = Color.Transparent;
            PauseButton.BackgroundImage = (Image)resources.GetObject("PauseButton.BackgroundImage");
            PauseButton.BackgroundImageLayout = ImageLayout.Stretch;
            PauseButton.Location = new Point(12, 12);
            PauseButton.Name = "PauseButton";
            PauseButton.Size = new Size(29, 32);
            PauseButton.TabIndex = 1;
            PauseButton.UseVisualStyleBackColor = false;
            PauseButton.Click += PauseButton_Click;
            // 
            // buttonSpecialAttack
            // 
            buttonSpecialAttack.BackColor = Color.DarkGray;
            buttonSpecialAttack.FlatStyle = FlatStyle.Popup;
            buttonSpecialAttack.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSpecialAttack.Location = new Point(356, 457);
            buttonSpecialAttack.Name = "buttonSpecialAttack";
            buttonSpecialAttack.Size = new Size(117, 39);
            buttonSpecialAttack.TabIndex = 2;
            buttonSpecialAttack.Text = "Special 💥";
            buttonSpecialAttack.UseVisualStyleBackColor = false;
            // 
            // buttonAttack
            // 
            buttonAttack.BackColor = Color.DarkGray;
            buttonAttack.FlatStyle = FlatStyle.Popup;
            buttonAttack.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAttack.ForeColor = Color.Black;
            buttonAttack.Location = new Point(491, 458);
            buttonAttack.Name = "buttonAttack";
            buttonAttack.Size = new Size(117, 39);
            buttonAttack.TabIndex = 3;
            buttonAttack.Text = "Attack ⚔️";
            buttonAttack.UseVisualStyleBackColor = false;
            // 
            // labelMana
            // 
            labelMana.AutoSize = true;
            labelMana.BackColor = Color.Silver;
            labelMana.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMana.Location = new Point(47, 421);
            labelMana.Name = "labelMana";
            labelMana.Size = new Size(122, 27);
            labelMana.TabIndex = 4;
            labelMana.Text = "Mana: 0 / 0";
            // 
            // labelBattleLog
            // 
            labelBattleLog.AutoSize = true;
            labelBattleLog.BackColor = Color.Silver;
            labelBattleLog.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBattleLog.ForeColor = SystemColors.ControlText;
            labelBattleLog.Location = new Point(732, 408);
            labelBattleLog.Name = "labelBattleLog";
            labelBattleLog.Size = new Size(106, 40);
            labelBattleLog.TabIndex = 5;
            labelBattleLog.Text = "Battle Log:\r\n\r\n";
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.BackColor = Color.Transparent;
            labelPlayerName.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPlayerName.ForeColor = SystemColors.ButtonFace;
            labelPlayerName.Location = new Point(61, 39);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(102, 27);
            labelPlayerName.TabIndex = 6;
            labelPlayerName.Text = "Player: ";
            // 
            // labelMonsterName
            // 
            labelMonsterName.AutoSize = true;
            labelMonsterName.BackColor = Color.Transparent;
            labelMonsterName.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMonsterName.ForeColor = SystemColors.ButtonFace;
            labelMonsterName.Location = new Point(597, 39);
            labelMonsterName.Name = "labelMonsterName";
            labelMonsterName.Size = new Size(90, 27);
            labelMonsterName.TabIndex = 7;
            labelMonsterName.Text = "Enemy:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(147, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 241);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(550, 137);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(269, 241);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pbarPlayerHP
            // 
            pbarPlayerHP.Location = new Point(61, 69);
            pbarPlayerHP.Name = "pbarPlayerHP";
            pbarPlayerHP.Size = new Size(269, 29);
            pbarPlayerHP.TabIndex = 10;
            // 
            // pbarMonsterHP
            // 
            pbarMonsterHP.ForeColor = Color.Red;
            pbarMonsterHP.Location = new Point(597, 69);
            pbarMonsterHP.Name = "pbarMonsterHP";
            pbarMonsterHP.Size = new Size(269, 29);
            pbarMonsterHP.TabIndex = 11;
            // 
            // pbarPlayerMana
            // 
            pbarPlayerMana.Location = new Point(47, 458);
            pbarPlayerMana.Name = "pbarPlayerMana";
            pbarPlayerMana.Size = new Size(269, 20);
            pbarPlayerMana.TabIndex = 12;
            // 
            // FormGameMode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(958, 523);
            Controls.Add(pbarPlayerMana);
            Controls.Add(pbarMonsterHP);
            Controls.Add(pbarPlayerHP);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelMonsterName);
            Controls.Add(labelPlayerName);
            Controls.Add(labelBattleLog);
            Controls.Add(labelMana);
            Controls.Add(buttonAttack);
            Controls.Add(buttonSpecialAttack);
            Controls.Add(PauseButton);
            Name = "FormGameMode";
            Text = "Game Battle scene";
            Load += FormGameMode_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PauseButton;
        private Button buttonSpecialAttack;
        private Button buttonAttack;
        private Label labelMana;
        private Label labelBattleLog;
        private Label labelPlayerName;
        private Label labelMonsterName;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ProgressBar pbarPlayerHP;
        private ProgressBar pbarMonsterHP;
        private ProgressBar pbarPlayerMana;
    }
}