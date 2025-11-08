using System;
using System.Windows.Forms;

namespace MetanoiaRPGGame
{
    public partial class FormLevelUp : Form
    {
        private Character player;

        public FormLevelUp(Character leveledUpPlayer)
        {
            InitializeComponent();
            player = leveledUpPlayer;
        }

        public FormLevelUp(Character leveledUpPlayer, Character player) : this(leveledUpPlayer)
        {
        }

        private void FormLevelUp_Load(object sender, EventArgs e)
        {
            lblName.Text = $"Name: {player.Name}";
            lblLevel.Text = $"Level: {player.Level}/20";
            lblHP.Text = $"HP: {player.HP}";
            lblAttack.Text = $"Attack: {player.Attack}";
            lblSpecial.Text = $"Special Attack: {player.SpecialAttack}";

            if (player.Level >= 20)
                lblMessage.Text = $"{player.Name} reached the MAX LEVEL!";
            else
                lblMessage.Text = $"You’re stronger now! Next level in {player.XPToNextLevel - player.XP} XP.";
        }

        private void NextGamebutton_Click(object sender, EventArgs e)
        {
            FormCharacterSelection menu = new FormCharacterSelection();
            menu.Show();
            this.Close();
        }
    }
}