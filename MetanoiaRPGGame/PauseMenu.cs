using System;


namespace MetanoiaRPGGame
{
    public partial class FormPauseMenu : Form
    {
        public FormPauseMenu()
        {
            InitializeComponent();
        }

        private void MainMenubutton_Click(object sender, EventArgs e)
        {
            FrmGameLobby lobby = new FrmGameLobby();
            lobby.Show();

            this.Close();
        }

        private void Resumebutton_Click(object sender, EventArgs e)
        {

            FormGameMode resume = new FormGameMode();
            resume.Show();

            this.Close();
        }
    }
}
