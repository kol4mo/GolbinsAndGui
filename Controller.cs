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



        public Form newEvent(Form prevForm)
        {
            int temp = new Random().Next(1);
            Form newform = null;
            switch(temp)
            {
                case 0:
                    newform = new Form1();
                    ((Form1)newform).SetController(this);
                    currentForm = newform;
                    newform.Show();
                    prevForm.Close();
                    break;
                case 1:
                    newform = new setupChar();
                    ((setupChar)newform).SetController(this);
                    currentForm = newform;
                    newform.Show();
                    prevForm.Close();
                    currentDialouge = 1;
                    model.Dialouge.adventurer1(this);
                    break;
                default:
                    newform = new setupChar();
                    break;
            }
            return newform;
        }

        public void changeOtherText(string text)
        {
        }

        public void changePlayerChoices(string choice1, string choice2)
        {
        }

        public void movecurrentDialoug(bool choice)
        {
            model.Dialouge.prevChoice = choice;
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
    }
}
