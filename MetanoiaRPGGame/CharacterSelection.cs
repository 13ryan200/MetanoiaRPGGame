using System;
using System.Windows.Forms;

namespace MetanoiaRPGGame
{
    public partial class FormCharacterSelection : Form
    {
        public FormCharacterSelection()
        {
            InitializeComponent();
        }

        private Character knight = new Character()
        { Name = "Knight", HP = 100, Attack = 30, SpecialAttack = 50 };

        private Character priest = new Character()
        { Name = "Priest", HP = 100, Attack = 20, SpecialAttack = 70 };

        private Character mage = new Character()
        { Name = "Mage", HP = 100, Attack = 25, SpecialAttack = 90 };

        private void picKnight_Click(object sender, EventArgs e)
        {
            rdoKnight.Checked = true;
        }

        private void picPriest_Click(object sender, EventArgs e)
        {
            rdoPriest.Checked = true;
        }

        private void picMage_Click(object sender, EventArgs e)
        {
            rdoMage.Checked = true;
        }

        private void Character_Click(object sender, EventArgs e)
        {
            PictureBox clicked = (PictureBox)sender;

            if (clicked == picKnight)
                MessageBox.Show(knight.ToString(), "Character Stats: Knight");
            else if (clicked == picPriest)
                MessageBox.Show(priest.ToString(), "Character Stats: Priest");
            else if (clicked == picMage)
                MessageBox.Show(mage.ToString(), "Character Stats: Mage");
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            Character selectedCharacter = null;

            if (rdoKnight.Checked)
                selectedCharacter = knight;
            else if (rdoPriest.Checked)
                selectedCharacter = priest;
            else if (rdoMage.Checked)
                selectedCharacter = mage;

            if (selectedCharacter == null)
            {
                MessageBox.Show("Please select a character before continuing!");
                return;
            }

            MessageBox.Show($"✅ Passing Character: {selectedCharacter.Name}");

            FormMonsterSelection monsterSelect = new FormMonsterSelection(selectedCharacter);
            monsterSelect.Show();
            this.Hide();
        }
    }
}
