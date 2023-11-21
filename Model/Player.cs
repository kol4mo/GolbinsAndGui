using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolbinsAndGui.model
{
    public class Player
    {
        private string name;
        private string pClass;
        private Random dice =new Random();
        public enum Moves
        {
            MAINHAND,
            MAGICMISSILE,
            FIREBALL,
            RAYOFFROST,
            LACARATE,

        }
        private Moves[] moves = new Moves[4];
        private int level;
        public int intellegence = 12;
        private int strength = 12;
        private int constitution = 12;
        public int hp { get; set; }
        public Player() { setPlayer(); } 
        public Player(string name, string lass, int Tell, int streng, int constit)
        {
            setPlayer(name, lass, Tell, streng, constit);
        }
        public void setPlayer(string iname = "no", string iClass = "Wizard", int Intellegence = 12, int istength = 12, int iconstitution = 12)
        {
            name = iname;
            pClass = iClass;
            intellegence = Intellegence;
            strength = istength; 
            constitution = iconstitution;
            hp = 20 + (constitution / 2 - 5);
            setMoves();
        }

        public void resetHP()
        {
            hp = 10 + (constitution / 2 - 5);
        }
        public void setMoves()
        {
            switch (pClass) {
                case "Wizard":
                    moves[0] = Moves.MAINHAND;
                    moves[1] = Moves.MAGICMISSILE;
                    moves[2] = Moves.FIREBALL;
                    moves[3] = Moves.RAYOFFROST;
                    break;

            }
        }

        public int attemptAttack(int move)
        {
            Moves temp = moves[move];
            switch (temp)
            {
                case Moves.MAINHAND:
                    return dice.Next(0,5);
                case Moves.MAGICMISSILE:
                    return rollDice(3, 4) + 3;
                case Moves.FIREBALL:
                    return rollDice(2, 6);
                case Moves.RAYOFFROST:
                    return rollDice(1, 9);
            }
            return 1;
        }

        public int rollDice(int amount, int size)
        {
            int temp = 0;
            for (int i = 0; i < amount; i++)
            {
                temp += dice.Next(0, size + 1);
            }
            return temp;
        }
        public void dealtDamage(int damage)
        {

        }

        public Moves[] getMoves()
        {
            return moves;
        }
    }
}
