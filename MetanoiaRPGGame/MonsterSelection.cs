using System;
using System.Windows.Forms;

namespace MetanoiaRPGGame
{
    public partial class FormMonsterSelection : Form
    {
        public Character selectedCharacter;
        public Monster selectedMonster;

        public FormMonsterSelection(Character selectedCharacter)
        {
            InitializeComponent();
            this.selectedCharacter = selectedCharacter;

            picCerberus.Image = Properties.Resources.Cerberus;
            picDragon.Image = Properties.Resources.Dragon;  
            picSerpent.Image = Properties.Resources.Serpent;  

            picCerberus.SizeMode = PictureBoxSizeMode.Zoom;
            picDragon.SizeMode = PictureBoxSizeMode.Zoom;
            picSerpent.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private Monster cerberus = new Monster() { Name = "Cerberus", HP = 150, Attack = 25 };
        private Monster dragon = new Monster() { Name = "Dragon", HP = 200, Attack = 30 };
        private Monster serpent = new Monster() { Name = "Serpent", HP = 100, Attack = 15 };

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

        private void Battlebutton_Click(object sender, EventArgs e)
        {
            if (rdoSerpent.Checked)
                selectedMonster = serpent;
            else if (rdoCerberus.Checked)
                selectedMonster = cerberus;
            else if (rdoDragon.Checked)
                selectedMonster = dragon;

            if (selectedCharacter == null)
            {
                MessageBox.Show("Please select a character!");
                return;
            }

            if (selectedMonster == null)
            {
                MessageBox.Show("Please select a monster!");
                return;
            }

            FormGameMode battle = new FormGameMode(selectedCharacter, selectedMonster);
            battle.Show();
            this.Hide();
        }
    }
}