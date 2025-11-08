using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetanoiaRPGGame
{
    public partial class FormGameMode : Form
    {
        private readonly Random rng = new Random();
        private Character player;
        private Monster monster;

        public FormGameMode(Character selectedCharacter, Monster selectedMonster)
        {
            InitializeComponent();
            this.player = selectedCharacter;
            this.monster = selectedMonster;
        }

        public Character Player => player;
        public Monster Monster => monster;

        private void FormGameMode_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"[DEBUG] Player = {player?.Name ?? "NULL"} | Monster = {monster?.Name ?? "NULL"}");

            if (player == null || monster == null)
            {
                MessageBox.Show("Error: Player or Monster was not properly initialized.", "Game Error");
                this.Close();
                return;
            }

            labelPlayerName.Text = $"Player: {player.Name}";
            labelMonsterName.Text = $"Enemy: {monster.Name}";

            picPlayer.Image = LoadImage(player.Name);
            picMonster.Image = LoadImage(monster.Name);

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
#nullable disable
        private Image LoadImage(string name)
        {
            try
            {
                MessageBox.Show($"🔎 Trying to load image: '{name}'", "Debug Check");

                object res = Properties.Resources.ResourceManager.GetObject(name);

                if (res == null)
                {
                    MessageBox.Show($"❌ Resource not found: '{name}'", "Missing Resource");
                    return Properties.Resources.Fallback;
                }

                MessageBox.Show($"✅ Found '{name}' (Type: {res.GetType().Name})");

                if (res is Bitmap bmp)
                    return bmp;

                if (res is byte[] bytes)
                {
                    using (var ms = new MemoryStream(bytes))
                        return new Bitmap(ms);
                }

                MessageBox.Show($"⚠️ Image not found or invalid for: '{name}'", "Missing Resource", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error loading image '{name}': {ex.Message}", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Properties.Resources.Fallback;
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

                FormLevelUp levelUpScreen = new FormLevelUp(player);
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
