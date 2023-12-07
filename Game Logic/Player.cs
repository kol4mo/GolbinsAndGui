namespace Game_Logic
{
    public class Player
    {
        private string name;
        private string pClass;
        private Random dice = new Random();
        public enum Moves
        {
            MAINHAND,
            MAGICMISSILE,
            FIREBALL,
            RAYOFFROST,
            LACARATE,
            GREATAXE,
            CROSSBOW,
            JAVELIN,
            HEAL

        }
        private Moves[] moves = new Moves[4];
        private int level;
        public int intellegence = 12;
        private int strength = 12;
        private int constitution = 12;
        private int dextarity = 12;
        private int wisdom = 12;
        private int maxHp;
        public int hp { get; set; }
        public int ac { get; set; }
        public Player()
        {
            string tempclass = "Wizard";
            switch (dice.Next(0, 3))
            {
                case 0:
                    tempclass = "Wizard";
                    break;
                case 1:
                    tempclass = "Fighter";
                    break;
                case 2:
                    tempclass = "Paladin";
                    break;

            }
            setPlayer("enemy", tempclass, rollDice(3, 6), rollDice(3, 6), rollDice(3, 6), rollDice(3, 6), rollDice(3, 6));
        }
        public Player(string name, string lass, int Tell, int streng, int constit, int dex, int wis)
        {
            setPlayer(name, lass, Tell, streng, constit, dex, wis);
        }
        public void setPlayer(string iname = "no", string iClass = "Wizard", int Intellegence = 12, int istength = 12, int iconstitution = 12, int idextarity = 12, int iwisdom = 12)
        {
            intellegence = Intellegence;
            strength = istength;
            constitution = iconstitution;
            dextarity = idextarity;
            wisdom = iwisdom;
            maxHp = rollDice(5, 10) + (constitution - 5);
            resetHP();
            name = iname;
            pClass = iClass;
            setMoves();
        }

        public void resetHP()
        {
            hp = maxHp;
        }
        public void setMoves()
        {
            switch (pClass)
            {
                case "Wizard":
                    moves[0] = Moves.MAINHAND;
                    moves[1] = Moves.MAGICMISSILE;
                    moves[2] = Moves.FIREBALL;
                    moves[3] = Moves.RAYOFFROST;
                    ac = 11 + (dextarity / 2 - 5);
                    break;
                case "Fighter":
                    moves[0] = Moves.MAINHAND;
                    moves[1] = Moves.LACARATE;
                    moves[2] = Moves.GREATAXE;
                    moves[3] = Moves.CROSSBOW;
                    ac = 12 + (dextarity / 2 - 5);
                    break;
                case "Paladin":
                    moves[0] = Moves.MAINHAND;
                    moves[1] = Moves.GREATAXE;
                    moves[2] = Moves.JAVELIN;
                    moves[3] = Moves.HEAL;
                    ac = 14 + (dextarity / 2 - 5);
                    break;
            }
            if (ac == 0)
            {
                ac = 11;
            }
        }

        public int attemptAttack(int move, int AC)
        {
            Moves temp = moves[move];
            switch (temp)
            {
                case Moves.MAINHAND:
                    if (rollDice(1, 20) + (strength / 2 - 5) > AC)
                    {
                        return rollDice(1, 4);
                    }
                    break;
                case Moves.MAGICMISSILE:
                    return rollDice(3, 4) + 3;
                case Moves.FIREBALL:
                    return rollDice(2, 6);
                case Moves.RAYOFFROST:
                    if (rollDice(1, 20) + (intellegence / 2 - 5) > AC)
                    {
                        return rollDice(1, 9);
                    }
                    break;
                case Moves.LACARATE:
                    if (rollDice(1, 20) + (dextarity / 2 - 5) > AC)
                    {
                        return rollDice(4, 8);
                    }
                    break;
                case Moves.GREATAXE:
                    if (rollDice(1, 20) + (strength / 2 - 5) > AC)
                    {
                        return rollDice(1, 12) + 3;
                    }
                    break;
                case Moves.CROSSBOW:
                    if (rollDice(1, 20) + (dextarity / 2 - 5) > AC)
                    {
                        return rollDice(1, 8) + 3;
                    }
                    break;
                case Moves.JAVELIN:
                    if (rollDice(1, 20) + (strength / 2 - 5) > AC)
                    {
                        return rollDice(1, 6) + 3;
                    }
                    break;
                case Moves.HEAL:
                    hp += 5;
                    if (hp > maxHp)
                    {
                        hp = maxHp;
                    }
                    return 0;

            }
            return 0;
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


        public Moves[] getMoves()
        {
            return moves;
        }
    }
}
