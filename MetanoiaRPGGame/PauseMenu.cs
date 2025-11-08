using System;
using System.Windows.Forms;

namespace MetanoiaRPGGame
{
    public partial class FormPauseMenu : Form
    {
        private FormGameMode game;

        public FormPauseMenu(FormGameMode gameForm)
        {
            InitializeComponent();
            game = gameForm;
        }

        private void Resumebutton_Click(object sender, EventArgs e)
        {
            game.Show();
            this.Hide();
        }

        private void MainMenubutton_Click(object sender, EventArgs e)
        {
            FrmGameLobby lobby = new FrmGameLobby();
            lobby.Show();

            game.Close();
            this.Close();
        }

        private void Restartbutton_Click(object sender, EventArgs e)
        {
            FormGameMode newBattle = new FormGameMode(game.Player.Clone(), game.Monster);
            newBattle.Show();

            game.Close();
            this.Close(); ;
        }
    }
}