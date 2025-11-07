using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace MetanoiaRPGGame
{
    public partial class FormCharacterSelection : Form
    {
        public FormCharacterSelection()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            InitializeComponent();
        }

        public Character SelectedCharacter { get; private set; }

        private Character knight = new Character()
        { Name = "Knight", HP = 100, Attack = 30, SpecialAttack = 50 };

        private Character priest = new Character()
        { Name = "Priest", HP = 100, Attack = 20, SpecialAttack = 70 };

        private Character mage = new Character()
        { Name = "Mage", HP = 100, Attack = 25, SpecialAttack = 90 };

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
            try
            {
                if (rdoKnight.Checked)
                    SelectedCharacter = knight;
                else if (rdoPriest.Checked)
                    SelectedCharacter = priest;
                else if (rdoMage.Checked)
                    SelectedCharacter = mage;

                if (SelectedCharacter == null)
                {
                    MessageBox.Show("Please select a character before continuing!");
                    return;
                }

                FormMonsterSelection next = new FormMonsterSelection(SelectedCharacter);
                next.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}