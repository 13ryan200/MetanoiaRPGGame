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

        public FormGameMode(Character selectedCharacter, Monster selectedMonster)
        {
            InitializeComponent();
            this.player = selectedCharacter;
            this.monster = selectedMonster;
        }

        private void FormGameMode_Load(object sender, EventArgs e)
        {
            if (player == null || monster == null)
            {
                MessageBox.Show("❌ Player or Monster was not passed correctly!");
                return;
            }

            labelBattleLog.Text = $"Debug Info:\nPlayer = {player.Name}\nMonster = {monster.Name}";

            labelPlayerName.Text = $"Player: {player.Name}";
            labelMonsterName.Text = $"Enemy: {monster.Name}";

            picPlayer.Image = GetImageByName(player.Name);
            picMonster.Image = GetImageByName(monster.Name);

            picPlayer.SizeMode = PictureBoxSizeMode.Zoom;
            picMonster.SizeMode = PictureBoxSizeMode.Zoom;

            pbarPlayerHP.Maximum = player.HP;
            pbarMonsterHP.Maximum = monster.HP;
            pbarPlayerMana.Maximum = player.MaxMana;

            pbarPlayerHP.Value = player.HP;
            pbarMonsterHP.Value = monster.HP;
            pbarPlayerMana.Value = player.Mana;

            UpdateUI();
        }

        private Bitmap GetImageByName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return null;

            try
            {
                object res = Properties.Resources.ResourceManager.GetObject(name);

                if (res is Bitmap bmp)
                    return bmp;

                if (res is byte[] bytes)
                {
                    using (var ms = new MemoryStream(bytes))
                        return new Bitmap(ms);
                }

                MessageBox.Show($"⚠️ Resource '{name}' found but not an image (type: {res?.GetType().Name ?? "null"})");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Failed to load image '{name}': {ex.Message}");
                return null;
            }
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
