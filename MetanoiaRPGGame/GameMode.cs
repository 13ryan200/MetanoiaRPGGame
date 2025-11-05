using System;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using MetanoiaRPGGame;

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
            player = selectedCharacter;
            monster = selectedMonster;
        }
    

    private void FormGameMode_Load(object sender, EventArgs e)
        {
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
                buttonAttack.Enabled = buttonSpecialAttack.Enabled = false;
                return;
            }

            MonsterCounter();

            UpdateUI();

            if (player.HP <= 0)
            {
                labelBattleLog.Text += $"\n{monster.Name} defeated {player.Name}!";
                buttonAttack.Enabled = buttonSpecialAttack.Enabled = false;
            }
        }
        private void UpdateUI()
        {
            pbarPlayerHP.Value = Math.Max(0, player.HP);
            pbarMonsterHP.Value = Math.Max(0, monster.HP);
            pbarPlayerMana.Value = Math.Max(0, player.Mana);

            labelMana.Text = $"Mana: {player.Mana}/{player.MaxMana}";
            buttonSpecialAttack.Enabled = player.CanUseSpecial;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            FormPauseMenu pause = new FormPauseMenu(this);
            pause.Show();

            this.Hide();
        } 
    }
}