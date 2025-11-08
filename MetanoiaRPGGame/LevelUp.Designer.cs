namespace MetanoiaRPGGame
{
    partial class FormLevelUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLevelUp));
            lblName = new Label();
            lblLevel = new Label();
            lblHP = new Label();
            lblAttack = new Label();
            lblSpecial = new Label();
            lblMessage = new Label();
            label1 = new Label();
            NextGamebutton = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Showcard Gothic", 15.75F);
            lblName.Image = (Image)resources.GetObject("lblName.Image");
            lblName.Location = new Point(110, 156);
            lblName.Name = "lblName";
            lblName.Size = new Size(80, 27);
            lblName.TabIndex = 0;
            lblName.Text = "Name: ";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.BackColor = Color.Transparent;
            lblLevel.Font = new Font("Showcard Gothic", 15.75F);
            lblLevel.Image = (Image)resources.GetObject("lblLevel.Image");
            lblLevel.Location = new Point(110, 186);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(79, 27);
            lblLevel.TabIndex = 1;
            lblLevel.Text = "level:";
            // 
            // lblHP
            // 
            lblHP.AutoSize = true;
            lblHP.BackColor = Color.Transparent;
            lblHP.Font = new Font("Showcard Gothic", 15.75F);
            lblHP.Image = (Image)resources.GetObject("lblHP.Image");
            lblHP.Location = new Point(110, 216);
            lblHP.Name = "lblHP";
            lblHP.Size = new Size(49, 27);
            lblHP.TabIndex = 2;
            lblHP.Text = "HP:";
            // 
            // lblAttack
            // 
            lblAttack.AutoSize = true;
            lblAttack.BackColor = Color.Transparent;
            lblAttack.Font = new Font("Showcard Gothic", 15.75F);
            lblAttack.Image = (Image)resources.GetObject("lblAttack.Image");
            lblAttack.Location = new Point(110, 244);
            lblAttack.Name = "lblAttack";
            lblAttack.Size = new Size(102, 27);
            lblAttack.TabIndex = 3;
            lblAttack.Text = "Attack: ";
            // 
            // lblSpecial
            // 
            lblSpecial.AutoSize = true;
            lblSpecial.BackColor = Color.Transparent;
            lblSpecial.Font = new Font("Showcard Gothic", 15.75F);
            lblSpecial.Image = (Image)resources.GetObject("lblSpecial.Image");
            lblSpecial.Location = new Point(110, 271);
            lblSpecial.Name = "lblSpecial";
            lblSpecial.Size = new Size(99, 27);
            lblSpecial.TabIndex = 4;
            lblSpecial.Text = "Special:";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Font = new Font("Showcard Gothic", 15.75F);
            lblMessage.Image = (Image)resources.GetObject("lblMessage.Image");
            lblMessage.Location = new Point(110, 318);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(115, 27);
            lblMessage.TabIndex = 5;
            lblMessage.Text = "Message: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(204, 35);
            label1.Name = "label1";
            label1.Size = new Size(544, 60);
            label1.TabIndex = 6;
            label1.Text = "You Have Leveled Up";
            // 
            // NextGamebutton
            // 
            NextGamebutton.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NextGamebutton.Image = (Image)resources.GetObject("NextGamebutton.Image");
            NextGamebutton.Location = new Point(308, 411);
            NextGamebutton.Name = "NextGamebutton";
            NextGamebutton.Size = new Size(324, 52);
            NextGamebutton.TabIndex = 7;
            NextGamebutton.Text = "Next Game";
            NextGamebutton.UseVisualStyleBackColor = true;
            // 
            // FormLevelUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Forest_of_Pixels_by_bunnsP_on_DeviantArt;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 499);
            Controls.Add(NextGamebutton);
            Controls.Add(label1);
            Controls.Add(lblMessage);
            Controls.Add(lblSpecial);
            Controls.Add(lblAttack);
            Controls.Add(lblHP);
            Controls.Add(lblLevel);
            Controls.Add(lblName);
            Name = "FormLevelUp";
            Text = "Level Up";
            Load += FormLevelUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblLevel;
        private Label lblHP;
        private Label lblAttack;
        private Label lblSpecial;
        private Label lblMessage;
        private Label label1;
        private Button NextGamebutton;
    }
}