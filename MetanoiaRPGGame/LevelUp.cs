using System;
using System.Windows.Forms;

namespace MetanoiaRPGGame
{
    public partial class FormLevelUp : Form
    {
        private Character playerBefore;
        private Character playerAfter;

        public FormLevelUp(Character playerBefore, Character playerAfter)
        {
            InitializeComponent();
            this.playerBefore = playerBefore;
            this.playerAfter = playerAfter;
        }

        private void FormLevelUp_Load(object sender, EventArgs e)
        {
            lblName.Text = $"🎖 {playerAfter.Name} Leveled Up!";
            lblLevel.Text = $"Level: {playerBefore.Level} → {playerAfter.Level}";
            lblHP.Text = $"HP: {playerBefore.HP} → {playerAfter.HP}";
            lblAttack.Text = $"Attack: {playerBefore.Attack} → {playerAfter.Attack}";
            lblSpecial.Text = $"Special: {playerBefore.SpecialAttack} → {playerAfter.SpecialAttack}";
            lblMessage.Text = "You’ve become stronger! Continue your adventure!";
        }

        private void NextGamebutton_Click(object sender, EventArgs e)
        {
            FormMonsterSelection monsterSelect = new FormMonsterSelection(playerAfter);
            monsterSelect.Show();

            this.Close();
        }
    }
}
