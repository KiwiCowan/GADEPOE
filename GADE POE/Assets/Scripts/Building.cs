using UnityEngine;


    public abstract class Building
    {
        protected int hp;
        protected int xPos;
        protected int yPos;
        protected string symbol;
        protected string faction;
        protected int resourcePerTick;
        protected int hammerHeadR;
        protected int raggerToothR;

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

        public int ResourcePerTick
        {
            get
            {
                return resourcePerTick;
            }

            set
            {
                resourcePerTick = value;
            }
        }

        public int HammerHeadR
        {
            get
            {
                return hammerHeadR;
            }

            set
            {
                hammerHeadR = value;
            }
        }

        public int RaggerToothR
        {
            get
            {
                return raggerToothR;
            }

            set
            {
                raggerToothR = value;
            }
        }

        //getters and setters


        public Building(int Xpos, int Ypos, string symbol, string faction)
        {

        }

        public virtual int HammerHeadR_Gen()
        {
            return 0;
        }

        public virtual int RaggerToothR_Gen()
        {
            return 0;
        }


    }

