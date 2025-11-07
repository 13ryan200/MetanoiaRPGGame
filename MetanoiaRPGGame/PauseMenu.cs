using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace MetanoiaRPGGame
{
    public partial class FormPauseMenu : Form
    {
        private FormGameMode gameForm;

        public FormPauseMenu(FormGameMode game)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            InitializeComponent();
            gameForm = game;
        }

        private void Resumebutton_Click(object sender, EventArgs e)
        {
            gameForm.Show();
            this.Hide();
        }

        private void MainMenubutton_Click(object sender, EventArgs e)
        {
            FrmGameLobby lobby = new FrmGameLobby();
            lobby.Show();

            gameForm.Close();
            this.Close();
        }
    }
}