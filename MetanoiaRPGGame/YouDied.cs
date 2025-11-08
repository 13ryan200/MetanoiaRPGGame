using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetanoiaRPGGame
{
    public partial class YouDied : Form
    {
        public YouDied()
        {
            InitializeComponent();
        }

        private void LobbyButton_Click(object sender, EventArgs e)
        {
            FrmGameLobby lobby = new FrmGameLobby();
            lobby.Show();
            this.Close();
        }


    }
}
