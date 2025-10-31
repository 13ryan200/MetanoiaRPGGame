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
            FormStoryMode story = new FormStoryMode();
            story.Show();

            this.Close();
        }
    }
}