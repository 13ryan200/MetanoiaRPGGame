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

        public string SelectedCharacter { get; private set; } = string.Empty;

        private Character knight = new Character()
        { Name = "Knight", HP = 100, Attack = 30, SpecialAttack = 50,  };
        private Character priest = new Character()
        { Name = "Priest", HP = 90, Attack = 20, SpecialAttack = 70,  };
        private Character mage = new Character()
        { Name = "Mage", HP = 80, Attack = 25, SpecialAttack = 90,  };

        private Character selectedCharacter;

        private void Character_Click(object sender, EventArgs e)
        {
            PictureBox clicked = (PictureBox)sender;

            if (clicked == picKnight)
            {
                MessageBox.Show(knight.ToString(), "Character Stats: Knight",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (clicked == picPriest)
            {
                MessageBox.Show(priest.ToString(), "Character Stats: Priest",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (clicked == picMage)
            {
                MessageBox.Show(mage.ToString(), "Character Stats: Mage",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
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

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            if (rdoKnight.Checked)
                SelectedCharacter = "Knight";
            else if (rdoPriest.Checked)
                SelectedCharacter = "Priest";
            else if (rdoMage.Checked)
                SelectedCharacter = "Mage";

            if (string.IsNullOrEmpty(SelectedCharacter))
            {
                MessageBox.Show("Please select a character before continuing!");
                return;
            }

            FormMonsterSelection next = new FormMonsterSelection(SelectedCharacter);
            next.Show();
            this.Hide();
        }
    }
}