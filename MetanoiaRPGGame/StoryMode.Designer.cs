namespace MetanoiaRPGGame
{
    partial class FormStoryMode
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStoryMode));
            PauseButton = new Button();
            Skipbutton = new Button();
            Storytimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            LabelDialogue = new Label();
            NextButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PauseButton
            // 
            PauseButton.BackColor = Color.Transparent;
            PauseButton.BackgroundImage = (Image)resources.GetObject("PauseButton.BackgroundImage");
            PauseButton.BackgroundImageLayout = ImageLayout.Stretch;
            PauseButton.Location = new Point(16, 16);
            PauseButton.Name = "PauseButton";
            PauseButton.Size = new Size(42, 40);
            PauseButton.TabIndex = 0;
            PauseButton.UseVisualStyleBackColor = false;
            PauseButton.Click += PauseButton_Click;
            // 
            // Skipbutton
            // 
            Skipbutton.BackColor = Color.Transparent;
            Skipbutton.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Skipbutton.Location = new Point(822, 16);
            Skipbutton.Name = "Skipbutton";
            Skipbutton.Size = new Size(87, 40);
            Skipbutton.TabIndex = 1;
            Skipbutton.Text = "Skip";
            Skipbutton.UseVisualStyleBackColor = false;
            // 
            // Storytimer
            // 
            Storytimer.Interval = 10000;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(67, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 275);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // LabelDialogue
            // 
            LabelDialogue.AutoSize = true;
            LabelDialogue.BackColor = SystemColors.MenuText;
            LabelDialogue.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelDialogue.ForeColor = SystemColors.ButtonFace;
            LabelDialogue.Location = new Point(16, 395);
            LabelDialogue.Name = "LabelDialogue";
            LabelDialogue.Padding = new Padding(20, 10, 20, 10);
            LabelDialogue.Size = new Size(87, 41);
            LabelDialogue.TabIndex = 4;
            LabelDialogue.Text = "\" . . . \"";
            LabelDialogue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NextButton
            // 
            NextButton.BackColor = Color.Transparent;
            NextButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NextButton.Location = new Point(714, 16);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(87, 40);
            NextButton.TabIndex = 5;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = false;
            // 
            // FormStoryMode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(944, 539);
            Controls.Add(NextButton);
            Controls.Add(LabelDialogue);
            Controls.Add(pictureBox1);
            Controls.Add(Skipbutton);
            Controls.Add(PauseButton);
            Name = "FormStoryMode";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PauseButton;
        private Button Skipbutton;
        private System.Windows.Forms.Timer Storytimer;
        private PictureBox pictureBox1;
        private Label LabelDialogue;
        private Button NextButton;
    }
}