using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetanoiaRPGGame
{
    public partial class FormGameMode : Form
    {
        private Character player;
        private Monster monster;
        private Random rng = new Random();

        public FormGameMode(Character selectedCharacter, Monster selectedMonster)
        {
            InitializeComponent();
            this.player = selectedCharacter;
            this.monster = selectedMonster;
        }

        private void FormGameMode_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BattleArena; 
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackColor = Color.Black;

            switch (player.Name)
            {
                case "Knight": picPlayer.Image = Properties.Resources.Knight; break;
                case "Priest": picPlayer.Image = Properties.Resources.Priest; break;
                case "Mage": picPlayer.Image = Properties.Resources.Mage; break;
                default: picPlayer.Image = null; break;
            }

            switch (monster.Name)
            {
                case "Dragon": picMonster.Image = Properties.Resources.Dragon; break;
                case "Cerberus": picMonster.Image = Properties.Resources.Cerberus; break;
                case "Serpent": picMonster.Image = Properties.Resources.Serpent; break;
                default: picMonster.Image = null; break;
            }

            if (picMonster.Image != null)
                picMonster.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            picPlayer.BackColor = Color.Transparent;
            picMonster.BackColor = Color.Transparent;
            picPlayer.SizeMode = PictureBoxSizeMode.Zoom;
            picMonster.SizeMode = PictureBoxSizeMode.Zoom;
            picPlayer.BringToFront();
            picMonster.BringToFront();

            labelPlayerName.Text = $"Player: {player.Name}";
            labelMonsterName.Text = $"Enemy: {monster.Name}";

            pbarPlayerHP.Maximum = player.HP;
            pbarMonsterHP.Maximum = monster.HP;
            pbarPlayerMana.Maximum = player.MaxMana;

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

            labelBattleLog.Text = $"{player.Name} attacks {monster.Name} for {playerDamage} damage!";
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

            labelBattleLog.Text = $"{player.Name} uses a SPECIAL ATTACK for {specialDamage}!";
            CheckBattleState();
        }

        private async void MonsterCounter()
        {
            if (monster.HP > 0)
            {
                int monsterDamage = rng.Next(monster.Attack - 5, monster.Attack + 5);
                player.HP = Math.Max(0, player.HP - monsterDamage);
                await AnimateHit(picPlayer);

                labelBattleLog.Text += $"\n{monster.Name} hits back for {monsterDamage}!";
            }
        }

        private async void CheckBattleState()
        {
            UpdateUI();

            if (monster.HP <= 0)
            {
                labelBattleLog.Text += $"\n{player.Name} defeated {monster.Name}!";
                btnAttack.Enabled = btnSpecial.Enabled = false;

                int xpGained = monster.Attack * 5;
                player.GainXP(xpGained);

                FormLevelUp YouWin = new FormLevelUp(player, player);
                YouWin.Show();
                this.Hide();
                
            }

            await Task.Delay(300);
            MonsterCounter();
            UpdateUI();

            if (player.HP <= 0)
            {
                labelBattleLog.Text += $"\n{monster.Name} defeated {player.Name}!";
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

        private void PauseButton_Click(object sender, EventArgs e)
        {
            FormPauseMenu pause = new FormPauseMenu(this);
            pause.Show();
            this.Hide();
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
    }
}