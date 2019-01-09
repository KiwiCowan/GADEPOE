using System.IO;
using UnityEngine;

    public class FactoryBuilding : Building
    {
        public FactoryBuilding(int Xpos, int Ypos, string symbol, string faction) : base(Xpos, Ypos, symbol, faction)
        {
            this.hp = 100;
            this.XPos = Xpos;
            this.YPos = Ypos;
             this.symbol = symbol;
            this.faction = faction;
           
        }

        public override string ToString()
        {
            string[] buildingUnits = GetType().ToString().Split('.');
            string buildingType = buildingUnits[buildingUnits.Length - 1];

            return buildingType  + "." + Faction + "." + Hp + "." + (XPos + 1) + "." + (YPos + 1) ;
        }

       
    }

