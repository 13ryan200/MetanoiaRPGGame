namespace MetanoiaRPGGame
{
    public partial class FrmGameLobby : Form
    {
        public FrmGameLobby()
        {
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