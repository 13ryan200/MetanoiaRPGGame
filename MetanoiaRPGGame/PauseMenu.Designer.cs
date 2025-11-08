namespace MetanoiaRPGGame
{
    partial class FormPauseMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPauseMenu));
            MainMenubutton = new Button();
            Resumebutton = new Button();
            PauseMenuLabel = new Label();
            Restartbutton = new Button();
            SuspendLayout();
            // 
            // MainMenubutton
            // 
            MainMenubutton.BackgroundImage = (Image)resources.GetObject("MainMenubutton.BackgroundImage");
            MainMenubutton.Font = new Font("Showcard Gothic", 15.75F);
            MainMenubutton.Image = (Image)resources.GetObject("MainMenubutton.Image");
            MainMenubutton.Location = new Point(328, 336);
            MainMenubutton.Name = "MainMenubutton";
            MainMenubutton.Size = new Size(280, 70);
            MainMenubutton.TabIndex = 2;
            MainMenubutton.Text = "Main Menu";
            MainMenubutton.UseVisualStyleBackColor = true;
            MainMenubutton.Click += MainMenubutton_Click;
            // 
            // Resumebutton
            // 
            Resumebutton.BackgroundImage = (Image)resources.GetObject("Resumebutton.BackgroundImage");
            Resumebutton.Font = new Font("Showcard Gothic", 15.75F);
            Resumebutton.Image = (Image)resources.GetObject("Resumebutton.Image");
            Resumebutton.Location = new Point(328, 161);
            Resumebutton.Name = "Resumebutton";
            Resumebutton.Size = new Size(280, 71);
            Resumebutton.TabIndex = 0;
            Resumebutton.Text = "Resume";
            Resumebutton.UseVisualStyleBackColor = true;
            Resumebutton.Click += Resumebutton_Click;
            // 
            // PauseMenuLabel
            // 
            PauseMenuLabel.AutoSize = true;
            PauseMenuLabel.BackColor = Color.Transparent;
            PauseMenuLabel.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PauseMenuLabel.Image = (Image)resources.GetObject("PauseMenuLabel.Image");
            PauseMenuLabel.Location = new Point(247, 27);
            PauseMenuLabel.Name = "PauseMenuLabel";
            PauseMenuLabel.Size = new Size(428, 79);
            PauseMenuLabel.TabIndex = 3;
            PauseMenuLabel.Text = "Pause Menu";
            // 
            // Restartbutton
            // 
            Restartbutton.BackgroundImage = (Image)resources.GetObject("Restartbutton.BackgroundImage");
            Restartbutton.Font = new Font("Showcard Gothic", 15.75F);
            Restartbutton.Image = (Image)resources.GetObject("Restartbutton.Image");
            Restartbutton.Location = new Point(328, 247);
            Restartbutton.Name = "Restartbutton";
            Restartbutton.Size = new Size(280, 71);
            Restartbutton.TabIndex = 4;
            Restartbutton.Text = "Restart";
            Restartbutton.UseVisualStyleBackColor = true;
            Restartbutton.Click += Restartbutton_Click;
            // 
            // FormPauseMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(958, 509);
            Controls.Add(Restartbutton);
            Controls.Add(PauseMenuLabel);
            Controls.Add(MainMenubutton);
            Controls.Add(Resumebutton);
            Name = "FormPauseMenu";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button MainMenubutton;
        private Button Resumebutton;
        private Label PauseMenuLabel;
        private Button Restartbutton;
    }
}