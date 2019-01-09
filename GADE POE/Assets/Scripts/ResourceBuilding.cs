using System.IO;
using UnityEngine;


    public class ResourceBuilding : Building
    {
        public ResourceBuilding(int Xpos, int Ypos, string faction, string symbol) : base(Xpos, Ypos, faction, symbol)
        {
            this.hp = 100;
            this.XPos = Xpos;
            this.YPos = Ypos;
            this.faction = faction;
            this.symbol = symbol;
            this.hammerHeadR = HammerHeadR;
            this.raggerToothR = RaggerToothR;
            this.resourcePerTick = 1;
        }

        public override string ToString()
        {
            string[] buildingUnits = GetType().ToString().Split('.');
            string buildingType = buildingUnits[buildingUnits.Length - 1];

            return buildingType + "." + Faction + "." + Hp + "." + (XPos + 1) + "." + (YPos + 1);
        }

        public override int HammerHeadR_Gen()
        {
            HammerHeadR = hammerHeadR + resourcePerTick;// adding resources 
            return HammerHeadR;
        }

        public override int RaggerToothR_Gen()
        {
            RaggerToothR = RaggerToothR + resourcePerTick;// adding resources
            return RaggerToothR;
        }

        
    }


