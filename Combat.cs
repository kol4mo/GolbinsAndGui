using System.Net.Http.Headers;

namespace GolbinsAndGui
{
    public partial class Combat : Form
    {
        Controller m_owner = new Controller();
        public Combat()
        {
            InitializeComponent();
        }
        public void SetController(Controller controller)
        {
            m_owner = controller;
        }
        public void setUpBattle(int playerHP, int enemyHP, string move1, string move2, string move3, string move4)
        {
            PlayerHP.Maximum = playerHP;
            EnemyHP.Maximum = enemyHP;
            PlayerHP.Value = playerHP;
            EnemyHP.Value = enemyHP;
            Attack1.Text = move1;
            Attack2.Text = move2;
            Attack3.Text = move3;
            Attack4.Text = move4;
        }
        private void Attack1_Click(object sender, EventArgs e)
        {
            m_owner.combat(0);
        }

        public void updateGame(string playerstring, string enemystring)
        {
            gameResponse.Text = playerstring;
            gameResponse.AppendText(enemystring);
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
            PlayerHP.Value = playerHP;
            EnemyHP.Value = enemyHP;
        }

        private void Attack2_Click(object sender, EventArgs e)
        {
            m_owner.combat(1);
        }

        private void Attack3_Click(object sender, EventArgs e)
        {
            m_owner.combat(2);
        }

        private void Attack4_Click(object sender, EventArgs e)
        {
            m_owner.combat(3);
        }


    }
}
