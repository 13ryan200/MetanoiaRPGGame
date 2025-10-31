namespace MetanoiaRPGGame
{
    partial class FrmGameLobby
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGameLobby));
            Startbutton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Startbutton
            // 
            Startbutton.BackColor = Color.Transparent;
            Startbutton.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Startbutton.Location = new Point(340, 455);
            Startbutton.Name = "Startbutton";
            Startbutton.Size = new Size(287, 78);
            Startbutton.TabIndex = 0;
            Startbutton.Text = "Start";
            Startbutton.UseVisualStyleBackColor = false;
            Startbutton.Click += Startbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(218, 35);
            label1.Name = "label1";
            label1.Size = new Size(522, 81);
            label1.TabIndex = 1;
            label1.Text = "Lost in Fukiko";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(340, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 310);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FrmGameLobby
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 545);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(Startbutton);
            Name = "FrmGameLobby";
            Text = "Lobby";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Startbutton;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
