using System;
using System.Windows.Forms;
using System.ComponentModel;


namespace MetanoiaRPGGame
{
    public partial class FrmGameLobby : Form
    {
        public FrmGameLobby()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            InitializeComponent();
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            FormCharacterSelection story = new FormCharacterSelection();
            story.Show();

            this.Hide();

        }
    }
}