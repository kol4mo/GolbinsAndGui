using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolbinsAndGui
{
    public class Player
    {
        private string name;
        private string pClass;
        public enum Moves
        {
            MAINHAND,
            MAGICMISSILE,
            FIREBALL,
            RAYOFFROST,
            LACARATE,

        }
        private Moves[] moves;
        private int level;
        private int intellegence;
        private int strength;
        private int constitution;
        public int hp { get; set; }
        public Player() { setPlayer(); } 
        public void setPlayer(string iname = "no", string iClass = "Wizard", int Intellegence = 12, int istength = 12, int iconstitution = 12)
        {
            name = iname;
            pClass = iClass;
            intellegence = Intellegence;
            strength = istength; 
            constitution = iconstitution;
            hp = 10 + (constitution / 2 - 5);
            setMoves();
        }
        public void setMoves()
        {
            switch (pClass) {
                case "Wizard":
                    moves = new Moves[4];
                    moves[0] = Moves.MAINHAND;
                    moves[1] = Moves.MAGICMISSILE;
                    moves[2] = Moves.FIREBALL;
                    moves[3] = Moves.RAYOFFROST;
                    break;

            }
        }

        public int attemptAttack(int move)
        {

            return 0;
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
