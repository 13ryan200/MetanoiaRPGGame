using System;

namespace MetanoiaRPGGame
{
    public partial class FormStoryMode : Form
    {
        public FormStoryMode()
        {
            InitializeComponent();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            FormPauseMenu pause = new FormPauseMenu();
            pause.Show();

            this.Close();
        }
    }
}
