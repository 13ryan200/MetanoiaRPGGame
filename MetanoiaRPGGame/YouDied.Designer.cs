namespace MetanoiaRPGGame
{
    partial class YouDied
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YouDied));
            label1 = new Label();
            Lobbybutton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(365, 56);
            label1.Name = "label1";
            label1.Size = new Size(251, 60);
            label1.TabIndex = 0;
            label1.Text = "You Died";
            // 
            // Lobbybutton
            // 
            Lobbybutton.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lobbybutton.Image = (Image)resources.GetObject("Lobbybutton.Image");
            Lobbybutton.Location = new Point(340, 391);
            Lobbybutton.Name = "Lobbybutton";
            Lobbybutton.Size = new Size(310, 53);
            Lobbybutton.TabIndex = 1;
            Lobbybutton.Text = "Return to Lobby";
            Lobbybutton.UseVisualStyleBackColor = true;
            Lobbybutton.Click += LobbyButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.YouDied;
            pictureBox1.Location = new Point(355, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 239);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // YouDied
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BattleArena;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(965, 492);
            Controls.Add(pictureBox1);
            Controls.Add(Lobbybutton);
            Controls.Add(label1);
            Name = "YouDied";
            Text = "You Died";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Lobbybutton;
        private PictureBox pictureBox1;
    }
}