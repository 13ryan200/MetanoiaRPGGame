#nullable disable
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetanoiaRPGGame
{
    public partial class FormGameMode : Form
    {
        private Random rng = new Random();
        private Character player;
        private Monster monster;

        public Character Player => this.player;
        public Monster Monster => this.monster;

        public FormGameMode(Character selectedCharacter, Monster selectedMonster)
        {
            InitializeComponent();
            this.player = selectedCharacter;
            this.monster = selectedMonster;
            FormGameMode_Load();
        }

        private void FormGameMode_Load()
        {

            labelPlayerName.Text = $"Player: {player.Name}";
            labelMonsterName.Text = $"Enemy: {monster.Name}";

            switch (player.Name)
            {
                case "Knight":
                    picPlayer.Image = Properties.Resources.Knight;
                    break;
                case "Priest":
                    picPlayer.Image = Properties.Resources.Priest;
                    break;
                case "Mage":
                    picPlayer.Image = Properties.Resources.Mage;
                    break;
                default:
                    picPlayer.Image = Properties.Resources.Fallback;
                    break;
            }
          
            switch (monster.Name)
            {
                case "Cerberus":
                    picMonster.Image = Properties.Resources.Cerberus;
                    break;
                case "Dragon":
                    picMonster.Image = Properties.Resources.Dragon;
                    break;
                case "Serpent":
                    picMonster.Image = Properties.Resources.Serpent;
                    break;
                default:
                    picMonster.Image = Properties.Resources.Fallback;
                    break;
            }
          
            picPlayer.SizeMode = PictureBoxSizeMode.Zoom;
            picMonster.SizeMode = PictureBoxSizeMode.Zoom;
            picPlayer.Refresh();
            picMonster.Refresh();
            pbarPlayerHP.Maximum = player.HP;
            pbarMonsterHP.Maximum = monster.HP;
            pbarPlayerMana.Maximum = player.MaxMana;
            pbarPlayerHP.Value = player.HP;
            pbarMonsterHP.Value = monster.HP;
            pbarPlayerMana.Value = player.Mana;

            UpdateUI();
        }

        private async void btnAttack_Click(object sender, EventArgs e)
        {
            await NormalAttack();
        }

        private async Task NormalAttack()
        {
            int playerDamage = rng.Next(player.Attack - 5, player.Attack + 5);
            monster.HP = Math.Max(0, monster.HP - playerDamage);
            await AnimateHit(picMonster);

            player.GainMana(20);
            LabelBattleLog.Text = $"{player.Name} attacks {monster.Name} for {playerDamage} damage!";

            CheckBattleState();
        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            SpecialAttack();
        }

        private void SpecialAttack()
        {
            if (!player.CanUseSpecial)
            {
                MessageBox.Show("Not enough mana for special attack!");
                return;
            }

            int specialDamage = player.SpecialAttack;
            monster.HP = Math.Max(0, monster.HP - specialDamage);
            player.UseMana();

            LabelBattleLog.Text = $"{player.Name} uses a SPECIAL ATTACK for {specialDamage}!";
            CheckBattleState();
        }

        private async void MonsterCounter()
        {
            if (monster.HP > 0)
            {
                int monsterDamage = rng.Next(monster.Attack - 5, monster.Attack + 5);
                player.HP = Math.Max(0, player.HP - monsterDamage);
                await AnimateHit(picPlayer);

                LabelBattleLog.Text += $"\n{monster.Name} hits back for {monsterDamage}!";
            }
        }

        private async void CheckBattleState()
        {
            UpdateUI();

            if (monster.HP <= 0)
            {
                LabelBattleLog.Text += $"\n{player.Name} defeated {monster.Name}!";
                btnAttack.Enabled = btnSpecial.Enabled = true;

                int xpGained = monster.Attack * 5;
                Character oldStats = player.Clone();
                player.GainXP(xpGained);

                FormLevelUp levelUpScreen = new FormLevelUp(oldStats, player);
                levelUpScreen.Show();
                this.Hide();
                return;
            }

            await Task.Delay(300);
            MonsterCounter();
            UpdateUI();

            if (player.HP <= 0)
            {
                LabelBattleLog.Text += $"\n{monster.Name} defeated {player.Name}!";
                btnAttack.Enabled = btnSpecial.Enabled = false;

                YouDied defeat = new YouDied();
                defeat.Show();
                this.Hide();
            }
        }

        private void UpdateUI()
        {
            pbarPlayerHP.Value = Math.Min(pbarPlayerHP.Maximum, Math.Max(0, player.HP));
            pbarMonsterHP.Value = Math.Min(pbarMonsterHP.Maximum, Math.Max(0, monster.HP));
            pbarPlayerMana.Value = Math.Min(pbarPlayerMana.Maximum, Math.Max(0, player.Mana));

            labelPlayerName.Text = $"{player.Name} HP: {player.HP}";
            labelMonsterName.Text = $"{monster.Name} HP: {monster.HP}";
            labelMana.Text = $"Mana: {player.Mana}/{player.MaxMana}";
            btnSpecial.Enabled = player.CanUseSpecial;
        }

        private async Task AnimateHit(PictureBox target)
        {
            Point original = target.Location;
            for (int i = 0; i < 3; i++)
            {
                target.Left += 10;
                await Task.Delay(50);
                target.Left -= 20;
                await Task.Delay(50);
                target.Left += 10;
            }
            target.Location = original;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            FormPauseMenu pause = new FormPauseMenu(this);
            pause.Show();
            this.Hide();
        }
    }
}
