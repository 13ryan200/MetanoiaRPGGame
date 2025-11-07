using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace MetanoiaRPGGame
{
    public partial class FormMonsterSelection : Form
    {
        private Character selectedCharacter;
        private Monster selectedMonster;

        private Monster cerberus = new Monster() { Name = "Cerberus", HP = 150, Attack = 25 };
        private Monster dragon = new Monster() { Name = "Dragon", HP = 200, Attack = 30 };
        private Monster serpent = new Monster() { Name = "Serpent", HP = 100, Attack = 20 };

        public string SelectedMonster { get; private set; } = string.Empty;

        public FormMonsterSelection(Character selectedCharacter)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            InitializeComponent();
            this.selectedCharacter = selectedCharacter;
        }

        private void Monster_Click(object sender, EventArgs e)
        {
            PictureBox clicked = (PictureBox)sender;

            if (clicked == picSerpent)
                MessageBox.Show(serpent.ToString(), "Monster Stats: Serpent");
            else if (clicked == picCerberus)
                MessageBox.Show(cerberus.ToString(), "Monster Stats: Cerberus");
            else if (clicked == picDragon)
                MessageBox.Show(dragon.ToString(), "Monster Stats: Dragon");
        }

        private void picSerpent_Click(object sender, EventArgs e)
        {
            rdoSerpent.Checked = true;
        }

        private void picCerberus_Click(object sender, EventArgs e)
        {
            rdoCerberus.Checked = true;
        }

        private void picDragon_Click(object sender, EventArgs e)
        {
            rdoDragon.Checked = true;
        }

        private void Battlebutton_Click(object sender, EventArgs e)
        {
            if (rdoSerpent.Checked)
                selectedMonster = serpent;
            else if (rdoCerberus.Checked)
                selectedMonster = cerberus;
            else if (rdoDragon.Checked)
                selectedMonster = dragon;

            if (selectedMonster == null)
            {
                MessageBox.Show("Please select a monster before continuing!");
                return;
            }

            SelectedMonster = selectedMonster.Name;

            FormGameMode battle = new FormGameMode(selectedCharacter, selectedMonster);
            battle.Show();
            this.Hide();
        }
    }
}
