using GolbinsAndGui.model;
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
        private model.NonPlayerCharacter conversation = new model.NonPlayerCharacter();
        private Response response = new Response();
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
                    changeOtherName("General Grevious");
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
            } else
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
