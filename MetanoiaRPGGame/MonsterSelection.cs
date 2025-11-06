using System;
using System.Windows.Forms;

namespace MetanoiaRPGGame
{
    public partial class FormMonsterSelection : Form
    {
        private Character selectedCharacter; 
        private Monster selectedMonster;

        private Monster cerberus = new Monster() { Name = "Cerberus", HP = 80, Attack = 15 };
        private Monster dragon = new Monster() { Name = "Dragon", HP = 150, Attack = 30 };
        private Monster serpent = new Monster() { Name = "Serpent", HP = 60, Attack = 10 };

        public string SelectedMonster { get; private set; } = string.Empty;

        public FormMonsterSelection(Character selectedCharacter)
        {
            InitializeComponent();
            this.selectedCharacter = selectedCharacter;
        }

        private void Monster_Click(object sender, EventArgs e)
        {
            PictureBox clicked = (PictureBox)sender;

            if (clicked == picSerpent)
                MessageBox.Show(serpent.ToString(), "Monster Stats: Serpent",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (clicked == picCerberus)
                MessageBox.Show(cerberus.ToString(), "Monster Stats: Cerberus",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (clicked == picDragon)
                MessageBox.Show(dragon.ToString(), "Monster Stats: Dragon",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
