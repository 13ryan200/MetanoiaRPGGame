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
            label2 = new Label();
            SuspendLayout();
            // 
            // Startbutton
            // 
            Startbutton.BackColor = Color.Transparent;
            Startbutton.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Startbutton.Image = (Image)resources.GetObject("Startbutton.Image");
            Startbutton.Location = new Point(337, 388);
            Startbutton.Name = "Startbutton";
            Startbutton.Size = new Size(267, 78);
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
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(219, 60);
            label1.Name = "label1";
            label1.Size = new Size(522, 81);
            label1.TabIndex = 1;
            label1.Text = "Lost in Fukiko";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(338, 141);
            label2.Name = "label2";
            label2.Size = new Size(267, 81);
            label2.TabIndex = 2;
            label2.Text = "Forest";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmGameLobby
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 545);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Startbutton);
            Name = "FrmGameLobby";
            Text = "Lobby";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Startbutton;
        private Label label1;
        private Label label2;
    }
}
