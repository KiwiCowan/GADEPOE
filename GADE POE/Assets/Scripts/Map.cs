using System;
using System.IO;
using UnityEngine;


    public class Map
    {
        public string[,] GameMap = new string[20, 20];
        public Unit[] units = new Unit[10];
        public Building[] buildings = new Building[5];

        System.Random rand = new System.Random();


        public Map()
        {

        }

        public void GenMap()
        {
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    //GameMap[y, x] = ",";
                }
            }
        }

        public void PopMap()
        {
            UnitSpawner();//
            BuildingSpawner();

            for (int j = 0; j < units.Length - 1; j++)
            {
                Console.WriteLine(units[j].ToString());
            }
            for (int k = 0; k < buildings.Length - 1; k++)
            {
                Console.WriteLine(buildings[k].ToString());
            }
        }

        public void UnitSpawner()//
        {
            for (int j = 0; j < units.Length; j++)
            {
                int UnitType;
                int factionAllocte;

                int x = rand.Next(1, 20);
                int y = rand.Next(1, 20);
                string faction = "";
                string symbol = "";
                UnitType = rand.Next(1, 5);

                switch (UnitType)
                {
                    case 1: //Melee baby sharks
                        factionAllocte = rand.Next(1, 3);
                        switch (factionAllocte)
                        {
                            case 1: //hammerHead sharks
                                faction = "Hammerhead";
                                symbol = "H";
                                break;

                            case 2: //raggertooth sharks 
                                faction = "Raggertooth";
                                symbol = "R";
                                break;
                        }
                        units[j] = new MeleeUnit(x, y, faction, symbol);
                        break;

                    case 2: //Ranged baby sharks
                        factionAllocte = rand.Next(1, 3);
                        switch (factionAllocte)
                        {
                            case 1:
                                faction = "Hammerhead";
                                symbol = "h";
                                break;

                            case 2:
                                faction = "Raggertooth";
                                symbol = "r";
                                break;
                        }
                        units[j] = new RangeUnit(x, y, faction, symbol);
                        break;
                    case 3: //cutie baby sharks0
                        factionAllocte = rand.Next(1, 3);
                        switch (factionAllocte)
                        {
                            case 1: //hammerHead sharks
                                faction = "Hammerhead";
                                symbol = "C";
                                break;

                            case 2: //raggertooth sharks 
                                faction = "Raggertooth";
                                symbol = "c";
                                break;
                        }
                        units[j] = new Cutie(x, y, faction, symbol);
                        break;
                    case 4: //agro baby sharks
                        factionAllocte = rand.Next(1, 3);
                        switch (factionAllocte)
                        {
                            case 1: //hammerHead sharks
                                faction = "Hammerhead";
                                symbol = "A";
                                break;

                            case 2: //raggertooth sharks 
                                faction = "Raggertooth";
                                symbol = "a";
                                break;
                        }
                        units[j] = new AgroSharks(x, y, faction, symbol);
                        break;
                }
                //GameMap[units[j].YPos, units[j].XPos] = units[j].Symbol;
            }
        }

        public void BuildingSpawner()
        {
            int j = 0;
            int factionAllocte;

            string faction = "";
            string symbol = "";

            buildings[j] = new FactoryBuilding(1, 1, "Q", "Hammerhead");
            GameMap[buildings[j].YPos, buildings[j].XPos] = buildings[j].Symbol;
            j++;
            buildings[j] = new FactoryBuilding(18, 18, "q", "Raggertooth");
            GameMap[buildings[j].YPos, buildings[j].XPos] = buildings[j].Symbol;

            for (int l = 2; l < buildings.Length ; l++) //gen of resource buildings
            {
                factionAllocte = rand.Next(1, 3);
                int x = rand.Next(1, 20);
                int y = rand.Next(1, 20);

                switch (factionAllocte)
                {
                    case 1:
                        faction = "Hammerhead";
                        symbol = "D";
                        break;

                    case 2:
                        faction = "Raggertooth";
                        symbol = "d";
                        break;
                }

                buildings[l] = new ResourceBuilding(x, y, faction, symbol);
                GameMap[buildings[l].YPos, buildings[l].XPos] = buildings[l].Symbol;//populating the building in the array
            }
        }

    }


