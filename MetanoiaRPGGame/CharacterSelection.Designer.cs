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
            Nextbutton = new Button();
            picKnight = new PictureBox();
            picPriest = new PictureBox();
            picMage = new PictureBox();
            label1 = new Label();
            rdoKnight = new RadioButton();
            rdoPriest = new RadioButton();
            rdoMage = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)picKnight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPriest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMage).BeginInit();
            SuspendLayout();
            // 
            // Nextbutton
            // 
            Nextbutton.BackColor = Color.Transparent;
            Nextbutton.BackgroundImageLayout = ImageLayout.Stretch;
            Nextbutton.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nextbutton.Image = (Image)resources.GetObject("Nextbutton.Image");
            Nextbutton.Location = new Point(391, 434);
            Nextbutton.Name = "Nextbutton";
            Nextbutton.Size = new Size(143, 60);
            Nextbutton.TabIndex = 1;
            Nextbutton.Text = "Next";
            Nextbutton.UseVisualStyleBackColor = false;
            Nextbutton.Click += Nextbutton_Click;
            // 
            // picKnight
            // 
            picKnight.BackColor = Color.Transparent;
            picKnight.BackgroundImageLayout = ImageLayout.Zoom;
            picKnight.ErrorImage = null;
            picKnight.Image = (Image)resources.GetObject("picKnight.Image");
            picKnight.ImageLocation = "";
            picKnight.InitialImage = null;
            picKnight.Location = new Point(133, 130);
            picKnight.Name = "picKnight";
            picKnight.Size = new Size(182, 237);
            picKnight.SizeMode = PictureBoxSizeMode.Zoom;
            picKnight.TabIndex = 2;
            picKnight.TabStop = false;
            picKnight.Click += Character_Click;
            // 
            // picPriest
            // 
            picPriest.BackColor = Color.Transparent;
            picPriest.BackgroundImageLayout = ImageLayout.Zoom;
            picPriest.ErrorImage = null;
            picPriest.Image = (Image)resources.GetObject("picPriest.Image");
            picPriest.InitialImage = null;
            picPriest.Location = new Point(377, 130);
            picPriest.Name = "picPriest";
            picPriest.Size = new Size(182, 237);
            picPriest.SizeMode = PictureBoxSizeMode.StretchImage;
            picPriest.TabIndex = 3;
            picPriest.TabStop = false;
            picPriest.Click += Character_Click;
            // 
            // picMage
            // 
            picMage.BackColor = Color.Transparent;
            picMage.BackgroundImageLayout = ImageLayout.Zoom;
            picMage.ErrorImage = null;
            picMage.Image = (Image)resources.GetObject("picMage.Image");
            picMage.InitialImage = null;
            picMage.Location = new Point(624, 130);
            picMage.Name = "picMage";
            picMage.Size = new Size(182, 237);
            picMage.SizeMode = PictureBoxSizeMode.StretchImage;
            picMage.TabIndex = 4;
            picMage.TabStop = false;
            picMage.Click += Character_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(214, 36);
            label1.Name = "label1";
            label1.Size = new Size(493, 46);
            label1.TabIndex = 5;
            label1.Text = "Choose Your Character";
            // 
            // rdoKnight
            // 
            rdoKnight.AutoSize = true;
            rdoKnight.BackColor = Color.Transparent;
            rdoKnight.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoKnight.Location = new Point(173, 382);
            rdoKnight.Name = "rdoKnight";
            rdoKnight.Size = new Size(102, 27);
            rdoKnight.TabIndex = 6;
            rdoKnight.TabStop = true;
            rdoKnight.Text = "Knight";
            rdoKnight.UseVisualStyleBackColor = false;
            // 
            // rdoPriest
            // 
            rdoPriest.AutoSize = true;
            rdoPriest.BackColor = Color.Transparent;
            rdoPriest.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoPriest.Location = new Point(423, 382);
            rdoPriest.Name = "rdoPriest";
            rdoPriest.Size = new Size(95, 27);
            rdoPriest.TabIndex = 7;
            rdoPriest.TabStop = true;
            rdoPriest.Text = "Priest";
            rdoPriest.UseVisualStyleBackColor = false;
            // 
            // rdoMage
            // 
            rdoMage.AutoSize = true;
            rdoMage.BackColor = Color.Transparent;
            rdoMage.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoMage.Location = new Point(676, 382);
            rdoMage.Name = "rdoMage";
            rdoMage.Size = new Size(79, 27);
            rdoMage.TabIndex = 8;
            rdoMage.TabStop = true;
            rdoMage.Text = "Mage";
            rdoMage.UseVisualStyleBackColor = false;
            // 
            // FormCharacterSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(944, 539);
            Controls.Add(rdoMage);
            Controls.Add(rdoPriest);
            Controls.Add(rdoKnight);
            Controls.Add(label1);
            Controls.Add(picMage);
            Controls.Add(picPriest);
            Controls.Add(picKnight);
            Controls.Add(Nextbutton);
            Name = "FormCharacterSelection";
            Text = "Choose your character";
            ((System.ComponentModel.ISupportInitialize)picKnight).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPriest).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Nextbutton;
        private PictureBox picKnight;
        private PictureBox picPriest;
        private PictureBox picMage;
        private Label label1;
        private RadioButton rdoKnight;
        private RadioButton rdoPriest;
        private RadioButton rdoMage;
    }
}