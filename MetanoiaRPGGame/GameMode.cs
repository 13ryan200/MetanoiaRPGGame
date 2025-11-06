using System;
using System.Windows.Forms;
using System.Drawing;

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
            switch (player.Name)
            {
                case "Knight":
                    picPlayer.Image = Properties.Resources.knight;
                    break;
                case "Priest":
                    picPlayer.Image = Properties.Resources.priest;
                    break;
                case "Mage":
                    picPlayer.Image = Properties.Resources.mage;
                    break;
            }

            switch (monster.Name)
            {
                case "Dragon":
                    picMonster.Image = Properties.Resources.Dragon;
                    break;
                case "Cerberus":
                    picMonster.Image = Properties.Resources.Cerberus;
                    break;
                case "Serpent":
                    picMonster.Image = Properties.Resources.Serpent;
                    break;
            }

            if (picMonster.Image != null)
                picMonster.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            labelPlayerName.Text = $"Player: {player.Name}";
            labelMonsterName.Text = $"Enemy: {monster.Name}";

            pbarPlayerHP.Maximum = player.HP;
            pbarMonsterHP.Maximum = monster.HP;
            pbarPlayerMana.Maximum = player.MaxMana;

            pbarPlayerHP.Value = player.HP;
            pbarMonsterHP.Value = monster.HP;
            pbarPlayerMana.Value = player.Mana;

            UpdateUI();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            NormalAttack();
        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            SpecialAttack();
        }

        private void NormalAttack()
        {
            int playerDamage = rng.Next(player.Attack - 5, player.Attack + 5);
            monster.HP -= playerDamage;
            if (monster.HP < 0) monster.HP = 0;

            player.GainMana(20);

            labelBattleLog.Text = $"{player.Name} attacks {monster.Name} for {playerDamage}!";
            CheckBattleState();
        }

        private void SpecialAttack()
        {
            if (!player.CanUseSpecial)
            {
                MessageBox.Show("Not enough mana for special attack!");
                return;
            }

            int specialDamage = player.SpecialAttack;
            monster.HP -= specialDamage;
            if (monster.HP < 0) monster.HP = 0;

            player.UseMana();
            labelBattleLog.Text = $"{player.Name} uses a SPECIAL ATTACK for {specialDamage} damage!";
            CheckBattleState();
        }

        private void MonsterCounter()
        {
            if (monster.HP > 0)
            {
                int monsterDamage = rng.Next(monster.Attack - 5, monster.Attack + 5);
                player.HP -= monsterDamage;
                if (player.HP < 0) player.HP = 0;

                labelBattleLog.Text += $"\n{monster.Name} hits back for {monsterDamage}!";
            }
        }

        private void CheckBattleState()
        {
            UpdateUI();

            if (monster.HP <= 0)
            {
                labelBattleLog.Text += $"\n{player.Name} defeated {monster.Name}!";
                btnAttack.Enabled = btnSpecial.Enabled = false;

                int xpGained = monster.Attack * 5;
                player.GainXP(xpGained);

                MessageBox.Show($"{player.Name} gained {xpGained} XP!\n" +
                                $"Current Level: {player.Level}\n" +
                                $"HP: {player.HP}, Attack: {player.Attack}, Special: {player.SpecialAttack}",
                                "Level Up!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return;
            }

            MonsterCounter();
            UpdateUI();

            if (player.HP <= 0)
            {
                labelBattleLog.Text += $"\n{monster.Name} defeated {player.Name}!";
                btnAttack.Enabled = btnSpecial.Enabled = false;
            }
        }

        private void UpdateUI()
        {
            pbarPlayerHP.Value = Math.Max(0, player.HP);
            pbarMonsterHP.Value = Math.Max(0, monster.HP);
            pbarPlayerMana.Value = Math.Max(0, player.Mana);

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

        private async void AnimateHit(PictureBox target)
        {
            Point original = target.Location;
            for (int i = 0; i < 3; i++)
            {
                target.Left += 10;
                await System.Threading.Tasks.Task.Delay(50);
                target.Left -= 20;
                await System.Threading.Tasks.Task.Delay(50);
                target.Left += 10;
            }
            target.Location = original;
        }
    }
}