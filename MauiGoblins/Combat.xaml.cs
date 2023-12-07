using Game_Logic;
using MauiGoblins.Ui;
using Microsoft.Maui.Controls;
using System.Numerics;

namespace MauiGoblins
{
    public partial class Combat : ContentPage
    {
        Controller controller;
        float playerMax;
        float EnemyMax;
        public Combat()
        {
            InitializeComponent();
        }

        public void setController(Controller controller)
        {
            this.controller = controller;
        }
        public void setUpBattle(int playerHP, int enemyHP, string move1, string move2, string move3, string move4)
        {
            playerMax = playerHP;
            EnemyMax = enemyHP;
            PlayerHP.Progress = playerHP/playerMax;
            EnemyHP.Progress = enemyHP/EnemyMax;
            Move0.Text = move1;
            Move1.Text = move2;
            Move2.Text = move3;
            Move3.Text = move4;
        }
        private void Attack1_Click(object sender, EventArgs e)
        {
            controller.combat(0);
        }

        public void updateGame(string playerstring, string enemystring)
        {
            gameResponse.Text = playerstring + "\n" + enemystring;
        }

        public void setHP(int playerHP, int enemyHP)
        {
            if (playerHP < 0)
            {
                playerHP = 0;
            }
            if (enemyHP < 0)
            {
                enemyHP = 0;
            }
            PlayerHP.Progress = playerHP/playerMax;
            EnemyHP.Progress = enemyHP/EnemyMax;
        }

        private void Attack2_Click(object sender, EventArgs e)
        {
            controller.combat(1);
        }   

        private void Attack3_Click(object sender, EventArgs e)
        {
            controller.combat(2);
        }

        private void Attack4_Click(object sender, EventArgs e)
        {
            controller.combat(3);
        }
    }
}