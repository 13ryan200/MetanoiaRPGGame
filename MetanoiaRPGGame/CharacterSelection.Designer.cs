namespace MetanoiaRPGGame
{
    partial class FormCharacterSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCharacterSelection));
            labelCharacterSelection = new Label();
            Nextbutton = new Button();
            picKnight = new PictureBox();
            rdoKnight = new RadioButton();
            rdoPriest = new RadioButton();
            picPriest = new PictureBox();
            rdoMage = new RadioButton();
            picMage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picKnight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPriest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMage).BeginInit();
            SuspendLayout();
            // 
            // labelCharacterSelection
            // 
            labelCharacterSelection.AutoSize = true;
            labelCharacterSelection.BackColor = Color.Transparent;
            labelCharacterSelection.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCharacterSelection.Image = (Image)resources.GetObject("labelCharacterSelection.Image");
            labelCharacterSelection.Location = new Point(218, 35);
            labelCharacterSelection.Name = "labelCharacterSelection";
            labelCharacterSelection.Size = new Size(493, 46);
            labelCharacterSelection.TabIndex = 0;
            labelCharacterSelection.Text = "Choose your Character";
            // 
            // Nextbutton
            // 
            Nextbutton.BackColor = Color.Transparent;
            Nextbutton.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nextbutton.Image = (Image)resources.GetObject("Nextbutton.Image");
            Nextbutton.Location = new Point(376, 418);
            Nextbutton.Name = "Nextbutton";
            Nextbutton.Size = new Size(218, 50);
            Nextbutton.TabIndex = 1;
            Nextbutton.Text = "Next";
            Nextbutton.UseVisualStyleBackColor = false;
            Nextbutton.Click += Nextbutton_Click;
            // 
            // picKnight
            // 
            picKnight.BackColor = Color.Transparent;
            picKnight.Image = Properties.Resources.Knight;
            picKnight.Location = new Point(109, 116);
            picKnight.Name = "picKnight";
            picKnight.Size = new Size(188, 237);
            picKnight.SizeMode = PictureBoxSizeMode.StretchImage;
            picKnight.TabIndex = 2;
            picKnight.TabStop = false;
            picKnight.Click += Character_Click;
            // 
            // rdoKnight
            // 
            rdoKnight.AutoSize = true;
            rdoKnight.BackColor = Color.Transparent;
            rdoKnight.Font = new Font("Showcard Gothic", 15.75F);
            rdoKnight.Location = new Point(164, 359);
            rdoKnight.Name = "rdoKnight";
            rdoKnight.Size = new Size(108, 31);
            rdoKnight.TabIndex = 3;
            rdoKnight.TabStop = true;
            rdoKnight.Text = "Knight";
            rdoKnight.UseVisualStyleBackColor = false;
            // 
            // rdoPriest
            // 
            rdoPriest.AutoSize = true;
            rdoPriest.BackColor = Color.Transparent;
            rdoPriest.Font = new Font("Showcard Gothic", 15.75F);
            rdoPriest.Location = new Point(433, 359);
            rdoPriest.Name = "rdoPriest";
            rdoPriest.Size = new Size(101, 31);
            rdoPriest.TabIndex = 5;
            rdoPriest.TabStop = true;
            rdoPriest.Text = "Priest";
            rdoPriest.UseVisualStyleBackColor = false;
            // 
            // picPriest
            // 
            picPriest.BackColor = Color.Transparent;
            picPriest.Image = Properties.Resources.Priest;
            picPriest.Location = new Point(387, 118);
            picPriest.Name = "picPriest";
            picPriest.Size = new Size(188, 237);
            picPriest.SizeMode = PictureBoxSizeMode.StretchImage;
            picPriest.TabIndex = 4;
            picPriest.TabStop = false;
            picPriest.Click += Character_Click;
            // 
            // rdoMage
            // 
            rdoMage.AutoSize = true;
            rdoMage.BackColor = Color.Transparent;
            rdoMage.Font = new Font("Showcard Gothic", 15.75F);
            rdoMage.Location = new Point(710, 359);
            rdoMage.Name = "rdoMage";
            rdoMage.Size = new Size(88, 31);
            rdoMage.TabIndex = 7;
            rdoMage.TabStop = true;
            rdoMage.Text = "Mage";
            rdoMage.UseVisualStyleBackColor = false;
            // 
            // picMage
            // 
            picMage.BackColor = Color.Transparent;
            picMage.Image = Properties.Resources.Mage;
            picMage.Location = new Point(657, 116);
            picMage.Name = "picMage";
            picMage.Size = new Size(188, 237);
            picMage.SizeMode = PictureBoxSizeMode.StretchImage;
            picMage.TabIndex = 6;
            picMage.TabStop = false;
            picMage.Click += Character_Click;
            // 
            // FormCharacterSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 508);
            Controls.Add(rdoMage);
            Controls.Add(picMage);
            Controls.Add(rdoPriest);
            Controls.Add(picPriest);
            Controls.Add(rdoKnight);
            Controls.Add(labelCharacterSelection);
            Controls.Add(picKnight);
            Controls.Add(Nextbutton);
            Name = "FormCharacterSelection";
            Text = "CharacterSelection";
            ((System.ComponentModel.ISupportInitialize)picKnight).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPriest).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCharacterSelection;
        private Button Nextbutton;
        private PictureBox picKnight;
        private RadioButton rdoKnight;
        private RadioButton rdoPriest;
        private PictureBox picPriest;
        private RadioButton rdoMage;
        private PictureBox picMage;
    }
}