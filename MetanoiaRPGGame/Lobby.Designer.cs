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
            GameLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Startbutton
            // 
            Startbutton.BackColor = Color.Transparent;
            Startbutton.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Startbutton.ForeColor = SystemColors.ControlText;
            Startbutton.Image = (Image)resources.GetObject("Startbutton.Image");
            Startbutton.Location = new Point(326, 414);
            Startbutton.Name = "Startbutton";
            Startbutton.Size = new Size(287, 78);
            Startbutton.TabIndex = 0;
            Startbutton.Text = "Start";
            Startbutton.UseVisualStyleBackColor = false;
            Startbutton.Click += Startbutton_Click;
            // 
            // GameLabel
            // 
            GameLabel.AutoSize = true;
            GameLabel.BackColor = Color.Transparent;
            GameLabel.BorderStyle = BorderStyle.Fixed3D;
            GameLabel.FlatStyle = FlatStyle.Popup;
            GameLabel.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GameLabel.ForeColor = Color.Black;
            GameLabel.Image = (Image)resources.GetObject("GameLabel.Image");
            GameLabel.Location = new Point(204, 74);
            GameLabel.Name = "GameLabel";
            GameLabel.Size = new Size(535, 81);
            GameLabel.TabIndex = 1;
            GameLabel.Text = "Lost in Fukiko \r\n";
            GameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(333, 155);
            label1.Name = "label1";
            label1.Size = new Size(280, 81);
            label1.TabIndex = 2;
            label1.Text = " Forest";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmGameLobby
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 528);
            Controls.Add(label1);
            Controls.Add(GameLabel);
            Controls.Add(Startbutton);
            Name = "FrmGameLobby";
            Text = "Lobby";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Startbutton;
        private Label GameLabel;
        private Label label1;
    }
}
