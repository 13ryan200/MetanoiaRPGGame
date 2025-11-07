namespace MetanoiaRPGGame
{
    partial class FormMonsterSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonsterSelection));
            Battlebutton = new Button();
            labelMonsterSelection = new Label();
            rdoDragon = new RadioButton();
            rdoCerberus = new RadioButton();
            rdoSerpent = new RadioButton();
            picDragon = new PictureBox();
            picCerberus = new PictureBox();
            picSerpent = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picDragon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerberus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSerpent).BeginInit();
            SuspendLayout();
            // 
            // Battlebutton
            // 
            Battlebutton.BackColor = Color.Transparent;
            Battlebutton.BackgroundImageLayout = ImageLayout.Stretch;
            Battlebutton.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Battlebutton.Image = (Image)resources.GetObject("Battlebutton.Image");
            Battlebutton.Location = new Point(405, 418);
            Battlebutton.Name = "Battlebutton";
            Battlebutton.Size = new Size(143, 79);
            Battlebutton.TabIndex = 2;
            Battlebutton.Text = "Battle";
            Battlebutton.UseVisualStyleBackColor = false;
            Battlebutton.Click += Battlebutton_Click;
            // 
            // labelMonsterSelection
            // 
            labelMonsterSelection.AutoSize = true;
            labelMonsterSelection.BackColor = Color.Transparent;
            labelMonsterSelection.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMonsterSelection.ForeColor = SystemColors.ControlText;
            labelMonsterSelection.Image = (Image)resources.GetObject("labelMonsterSelection.Image");
            labelMonsterSelection.Location = new Point(247, 53);
            labelMonsterSelection.Name = "labelMonsterSelection";
            labelMonsterSelection.Size = new Size(448, 46);
            labelMonsterSelection.TabIndex = 6;
            labelMonsterSelection.Text = "Choose Your Monster\r\n";
            // 
            // rdoDragon
            // 
            rdoDragon.AutoSize = true;
            rdoDragon.BackColor = Color.Transparent;
            rdoDragon.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoDragon.Location = new Point(739, 374);
            rdoDragon.Name = "rdoDragon";
            rdoDragon.Size = new Size(106, 27);
            rdoDragon.TabIndex = 14;
            rdoDragon.TabStop = true;
            rdoDragon.Text = "Dragon";
            rdoDragon.UseVisualStyleBackColor = false;
            // 
            // rdoCerberus
            // 
            rdoCerberus.AutoSize = true;
            rdoCerberus.BackColor = Color.Transparent;
            rdoCerberus.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoCerberus.Location = new Point(416, 374);
            rdoCerberus.Name = "rdoCerberus";
            rdoCerberus.Size = new Size(123, 27);
            rdoCerberus.TabIndex = 13;
            rdoCerberus.TabStop = true;
            rdoCerberus.Text = "Cerberus";
            rdoCerberus.UseVisualStyleBackColor = false;
            // 
            // rdoSerpent
            // 
            rdoSerpent.AutoSize = true;
            rdoSerpent.BackColor = Color.Transparent;
            rdoSerpent.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoSerpent.Location = new Point(141, 374);
            rdoSerpent.Name = "rdoSerpent";
            rdoSerpent.Size = new Size(111, 27);
            rdoSerpent.TabIndex = 12;
            rdoSerpent.TabStop = true;
            rdoSerpent.Text = "Serpent";
            rdoSerpent.UseVisualStyleBackColor = false;
            // 
            // picDragon
            // 
            picDragon.BackColor = Color.Transparent;
            picDragon.BackgroundImageLayout = ImageLayout.Zoom;
            picDragon.ErrorImage = null;
            picDragon.Image = Properties.Resources.Dragon;
            picDragon.InitialImage = null;
            picDragon.Location = new Point(672, 152);
            picDragon.Name = "picDragon";
            picDragon.Size = new Size(222, 207);
            picDragon.SizeMode = PictureBoxSizeMode.StretchImage;
            picDragon.TabIndex = 11;
            picDragon.TabStop = false;
            picDragon.Click += Monster_Click;
            // 
            // picCerberus
            // 
            picCerberus.BackColor = Color.Transparent;
            picCerberus.BackgroundImageLayout = ImageLayout.Zoom;
            picCerberus.ErrorImage = null;
            picCerberus.Image = Properties.Resources.Cerberus;
            picCerberus.InitialImage = null;
            picCerberus.Location = new Point(339, 152);
            picCerberus.Name = "picCerberus";
            picCerberus.Size = new Size(295, 207);
            picCerberus.SizeMode = PictureBoxSizeMode.StretchImage;
            picCerberus.TabIndex = 10;
            picCerberus.TabStop = false;
            picCerberus.Click += Monster_Click;
            // 
            // picSerpent
            // 
            picSerpent.BackColor = Color.Transparent;
            picSerpent.BackgroundImageLayout = ImageLayout.Zoom;
            picSerpent.ErrorImage = null;
            picSerpent.Image = Properties.Resources.Serpent;
            picSerpent.ImageLocation = "";
            picSerpent.InitialImage = null;
            picSerpent.Location = new Point(86, 152);
            picSerpent.Name = "picSerpent";
            picSerpent.Size = new Size(198, 207);
            picSerpent.SizeMode = PictureBoxSizeMode.Zoom;
            picSerpent.TabIndex = 9;
            picSerpent.TabStop = false;
            picSerpent.Click += Monster_Click;
            // 
            // FormMonsterSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(956, 523);
            Controls.Add(rdoDragon);
            Controls.Add(rdoCerberus);
            Controls.Add(rdoSerpent);
            Controls.Add(picDragon);
            Controls.Add(picCerberus);
            Controls.Add(picSerpent);
            Controls.Add(labelMonsterSelection);
            Controls.Add(Battlebutton);
            Name = "FormMonsterSelection";
            Text = "Choose your monsters";
            ((System.ComponentModel.ISupportInitialize)picDragon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerberus).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSerpent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Battlebutton;
        private Label labelMonsterSelection;
        private RadioButton rdoDragon;
        private RadioButton rdoCerberus;
        private RadioButton rdoSerpent;
        private PictureBox picDragon;
        private PictureBox picCerberus;
        private PictureBox picSerpent;
    }
}