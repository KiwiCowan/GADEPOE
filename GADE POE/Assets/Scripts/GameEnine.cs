using UnityEngine;



public class GameEngine
{
    public Map map = new Map();
    public ResourceBuilding resources = new ResourceBuilding(0, 0, ".", ".");
    bool playing = true;

    public GameEngine()
    {

    }

    public bool Playing
    {
        get
        {
            return playing;
        }
    }

    public void PlayGame()
    {
        map.UnitSpawner();
        map.BuildingSpawner();

        for (int j = 0; j < map.buildings.Length; j++)
        {
            if (map.buildings[j] != null)
                map.GameMap[map.buildings[j].YPos, map.buildings[j].XPos] = map.buildings[j].Symbol;
        }
    }

    public void StartGame()
    {

        for (int j = 0; j < map.units.Length; j++) //runs though all units 
        {
            if (map.units[j] != null)
            {
                map.GameMap[map.units[j].YPos, map.units[j].XPos] = ",";

                if (map.units[j].Hp > 0)
                {

                    //int ClosestUnit = map.units[j].ClosestUnitPos(map.units, j);
                    //System.Console.WriteLine(j + " unit " + map.units[j].Faction + " finds  unit " + ClosestUnit + " , " + map.units[j].Faction + " at" + map.units[ClosestUnit].XPos + " , "  + map.units[ClosestUnit].YPos);
                    if (map.units[j].Hp / map.units[j].MaxHP * 100 > 25 / 100)
                    {

                        if (map.units[j].AttackRangeCheck(map.units[j].ClosestUnit(map.units)) == true)
                        {
                            map.units[j].Combat(map.units[j].ClosestUnit(map.units));
                        }
                        else
                        {
                            map.units[j].MoveUnitPos(map.units[j].ClosestUnit(map.units));
                            map.GameMap[map.units[j].YPos, map.units[j].XPos] = map.units[j].Symbol;
                        }
                    }
                    else
                    {
                        map.units[j].RunRandom();
                    }
                }
                else
                {
                    map.GameMap[map.units[j].YPos, map.units[j].XPos] = ",";
                    map.units[j] = null;
                }
            }
            //System.Console.WriteLine(map.units[j].ToString());
            //Unit clostest = map.units[j].ClosestUnit(map.units);
            //System.Console.WriteLine("unit " + j + "is looking for " + clostest.ToString());
        }
    }
}

