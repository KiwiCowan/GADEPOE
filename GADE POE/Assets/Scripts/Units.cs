using UnityEngine;


    public abstract class Unit
    {
        //varibles
        protected int xPos;
        protected int yPos;
        protected int hp;
        protected int atk;
        protected int range;
        protected string faction;
        protected string symbol;
        protected int maxHP;
        protected bool attacking;
        //getters and setters
        public int XPos
        {
            get
            {
                return xPos;
            }
            set
            {
                xPos = value;
            }
        }

        public int YPos
        {
            get
            {
                return yPos;
            }
            set
            {
                yPos = value;
            }
        }
        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
            }
        }
        public int Atk
        {
            get
            {
                return atk;
            } set
            {
                atk = value;
            }
        }

        public int Range
        {
            get
            {
                return range;
            }

            set
            {
                range = value;
            }
        }

        public string Faction
        {
            get
            {
                return faction;
            }

            set
            {
                faction = value;
            }
        }

        public string Symbol
        {
            get
            {
                return symbol;
            }

            set
            {
                symbol = value;
            }
        }

        public int MaxHP
        {
            get
            {
                return maxHP;
            }

            set
            {
                maxHP = value;
            }
        }

        public bool Attacking
        {
            get
            {
                return attacking;
            }

            set
            {
                attacking = value;
            }
        }

        public Unit(int Xpos, int Ypos, string faction, string symbol)
        {
        }

        public abstract Unit ClosestUnit(Unit[] units);

        public abstract bool AttackRangeCheck(Unit unit);

        public abstract void MoveUnitPos(Unit unit);

        public abstract void Combat(Unit unit);

        public abstract void RunRandom();



    }


