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
            pictureBox1 = new PictureBox();
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(77, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 275);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormGameMode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(958, 523);
            Controls.Add(pictureBox1);
            Controls.Add(PauseButton);
            Name = "FormGameMode";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button PauseButton;
        private PictureBox pictureBox1;
    }
}