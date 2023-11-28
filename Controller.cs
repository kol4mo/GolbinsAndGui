
using Game_Logic;

namespace GolbinsAndGui
{
    public class Controller
    {
        public Player m_player = new Player();
        public Player m_enemy = new Player();
        private NonPlayerCharacter conversation = new NonPlayerCharacter();
        private Response response = new Response();
        private int currentDialouge;
        Form currentForm;
        public void initPlayer(string name, string pClass, int intellegence, int strength, int constitution, int dextarity, int wisdom)
        {
            m_player.setPlayer(name, pClass, intellegence, strength, constitution, dextarity, wisdom);
        }



        public void newEvent(Form prevForm)
        {
            int temp = new Random().Next(0, 3);
            switch (temp)
            {
                case 0:
                    var c = FormManager.Current.CreateForm<Combat>();
                    (c).SetController(this);
                    currentForm = c;
                    c.Show();
                    m_enemy = new Player();
                    setUpBattle();
                    prevForm.Close();
                    break;
                case 1:
                    var f2 = FormManager.Current.CreateForm<Form1>();
                    (f2).SetController(this);
                    currentForm = f2;
                    f2.Show();
                    prevForm.Close();
                    changeOtherName("Eldran Shadowvale");
                    response = conversation.setupResponse(0);
                    changeOtherText();
                    changePlayerChoices();
                    break;
                case 2:
                    var f3 = FormManager.Current.CreateForm<Form1>();
                    (f3).SetController(this);
                    currentForm = f3;
                    f3.Show();
                    prevForm.Close();
                    changeOtherName("Sylas Nightshade");
                    response = conversation.setupResponse(1);
                    changeOtherText();
                    changePlayerChoices();
                    break;

                default:
                    break;
            }
        }
        public void changeOtherName(string name)
        {
            ((Form1)currentForm).setName(name);
        }
        public void changeOtherText()
        {
            ((Form1)currentForm).setText(response.responseText);
        }

        public void changePlayerChoices()
        {
            ((Form1)currentForm).setchoices(response.dialogueOptions.Keys.ToArray()[0], response.dialogueOptions.Keys.ToArray()[1]);
        }

        public void moveDialogue(int choice)
        {
            response = response.dialogueOptions.Values.ToArray()[choice];
            if (response.dialogueOptions.Keys.ToArray().Length > 0)
            {
                changeOtherText();
                changePlayerChoices();
            }
            else
            {
                newEvent(currentForm);
            }
        }

        public void setUpBattle()
        {
            m_player.resetHP();
            m_enemy.resetHP();
            ((Combat)currentForm).setUpBattle(m_player.hp, m_enemy.hp, m_player.getMoves()[0].ToString(), m_player.getMoves()[1].ToString(), m_player.getMoves()[2].ToString(), m_player.getMoves()[3].ToString());
        }


        public void combat(int move)
        {
            int playerDamage = m_player.attemptAttack(move, m_enemy.ac);
            int enemyDamage = m_enemy.attemptAttack(new Random().Next(0, 4), m_player.ac);
            m_enemy.hp -= playerDamage;
            m_player.hp -= enemyDamage;
            setHP();
            string playerstring = "";
            if (m_player.getMoves()[move] != Player.Moves.HEAL && playerDamage == 0)
            {
                playerstring = "You Missed.";
            } else if (m_player.getMoves()[move] == Player.Moves.HEAL) {
                playerstring = "You Healed.";
            } else
            {
                playerstring = "You Dealt " + playerDamage + " Damage.";
            }
            string enemystring = "";
            if (m_enemy.getMoves()[move] != Player.Moves.HEAL && enemyDamage == 0)
            {
                enemystring = "The Enemy Missed.";
            }
            else if (m_enemy.getMoves()[move] == Player.Moves.HEAL)
            {
                enemystring = "The Enemy Healed.";
            }
            else
            {
                enemystring = "The Enemy Dealt " + playerDamage + " Damage.";
            }
            ((Combat)currentForm).updateGame(playerstring, enemystring);
            if (m_enemy.hp <= 0)
            {
                //combat ui you win
                newEvent(currentForm);
            }
            if (m_player.hp <= 0)
            {
                //combat ui lose
                newEvent(currentForm);
            }
        }
        public void setHP()
        {
            ((Combat)currentForm).setHP(m_player.hp, m_enemy.hp);
        }
    }
}
