using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GolbinsAndGui
{
    public class Controller
    {
        public model.Player m_player = new model.Player();
        public model.Player m_enemy = new model.Player();
        private int currentDialouge;
        Form currentForm;
        public void initPlayer(string name, string pClass, int intellegence, int strength, int constitution)
        {
            m_player.setPlayer(name, pClass, intellegence, strength, constitution);
        }



        public void newEvent(Form prevForm)
        {
            int temp = new Random().Next(0,2);
            switch(temp)
            {
                case 0:
                    var c = FormManager.Current.CreateForm<Combat>();
                    (c).SetController(this);
                    currentForm = c;
                    c.Show();
                    setUpBattle();
                    prevForm.Close();
                    break;
                case 1:
                    var f2 = FormManager.Current.CreateForm<Form1>();
                    (f2).SetController(this);
                    currentForm = f2;
                    f2.Show();
                    prevForm.Close();
                    currentDialouge = 1;
                    model.Dialouge.dialougePosition = 0;
                    model.Dialouge.adventurer1(this);
                    break;
                default:
                    break;
            }
        }
        public void changeOtherName(string name)
        {
            ((Form1)currentForm).setName(name);
        }
        public void changeOtherText(string text)
        {
            ((Form1)currentForm).setText(text);
        }

        public void changePlayerChoices(string choice1, string choice2)
        {
            ((Form1)currentForm).setchoices(choice1, choice2);
        }

        public void setUpBattle()
        {
            m_player.resetHP();
            m_enemy.resetHP();
            ((Combat)currentForm).setUpBattle(m_player.hp, m_enemy.hp, m_player.getMoves()[0].ToString(), m_player.getMoves()[1].ToString(), m_player.getMoves()[2].ToString(), m_player.getMoves()[3].ToString());
        }

        public void movecurrentDialoug(bool choice)
        {
            model.Dialouge.choice = choice;
            switch(currentDialouge)
            {
                case 1:
                    if (model.Dialouge.adventurer1(this) == 1)
                    {
                        newEvent(currentForm);
                    }
                    break;
                default:
                    break;
            }
        }

        public void combat(int move)
        {
            m_enemy.hp -= m_player.attemptAttack(move);
            m_player.hp -= m_enemy.attemptAttack(new Random().Next(0,4));
            setHP();
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
