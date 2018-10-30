using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class GameManager : MonoBehaviour
{

    GameEngine ge;
    const float PADDING = 5.12f;
    float xOff, yOff;

    private int count = 0;
    private const int REFRESH_RATE = 60;
    // Use this for initialization
    void Start()
    {
        ge = new GameEngine();
        xOff = (-2 * Camera.main.orthographicSize) / 2;
        yOff = Camera.main.orthographicSize;
        FullGrass();
        ge.PlayGame();
        FullUnit();

    }

    // Update is called once per frame
    void Update()
    {


        if (ge.Playing && count % REFRESH_RATE == 0)
        {
            //ge.PlayGame();
            // CheckDeath();
            //Redraw(); 
            ge.StartGame();
            Redraw();
        }
        count++;
    }

    void FullUnit()
    {
        for (int j = 0; j < ge.map.buildings.Length; j++)
        {
            if (ge.map.buildings[j].Symbol == "Q")
            {
                Instantiate(Resources.Load("QueenSharkH"), new Vector3(xOff + (ge.map.units[j].XPos * PADDING), yOff + (-ge.map.units[j].YPos * PADDING), -1), Quaternion.identity);
            }
            if (ge.map.buildings[j].Symbol == "q")
            {
                Instantiate(Resources.Load("QueenSharkR"), new Vector3(xOff + (ge.map.units[j].XPos * PADDING), yOff + (-ge.map.units[j].YPos * PADDING), -1), Quaternion.identity);
            }
            if (ge.map.buildings[j].Symbol == "D")
            {
                Instantiate(Resources.Load("DaddySharkH"), new Vector3(xOff + (ge.map.units[j].XPos * PADDING), yOff + (-ge.map.units[j].YPos * PADDING), -1), Quaternion.identity);
            }
            if (ge.map.buildings[j].Symbol == "d")
            {
                Instantiate(Resources.Load("DaddySharkR"), new Vector3(xOff + (ge.map.units[j].XPos * PADDING), yOff + (-ge.map.units[j].YPos * PADDING), -1), Quaternion.identity);
            }
           
        }

        for (int k = 0; k < ge.map.units.Length; k++)
        {
            if (ge.map.units[k] != null)
            {
                if (ge.map.units[k].Symbol == "H")
                {
                    Instantiate(Resources.Load("BabySharkH"), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -1), Quaternion.identity);
                }
                else if (ge.map.units[k].Symbol == "R")
                {
                    Instantiate(Resources.Load("BabySharkR"), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -1), Quaternion.identity);
                }

                else if (ge.map.units[k].Symbol == "h")
                {
                    Instantiate(Resources.Load("BabySharkH_Range"), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -1), Quaternion.identity);
                }
                else if (ge.map.units[k].Symbol == "r")
                {
                    Instantiate(Resources.Load("BabySharkR_Range"), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -1), Quaternion.identity);
                }
                else if (ge.map.units[k].Symbol == "C")
                {
                    Instantiate(Resources.Load("BabySharkH_Cute"), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -1), Quaternion.identity);
                }
                else if (ge.map.units[k].Symbol == "c")
                {
                    Instantiate(Resources.Load("BabySharkR_Cute"), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -1), Quaternion.identity);
                }
                else if (ge.map.units[k].Symbol == "A")
                {
                    Instantiate(Resources.Load("BabySharkH_Agro"), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -1), Quaternion.identity);
                }
                else if (ge.map.units[k].Symbol == "a")
                {
                    Instantiate(Resources.Load("BabySharkR_Agro"), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -1), Quaternion.identity);
                }
            }
        }
    }

    void FullGrass()
    {
        for (int y = 0; y < 20; y++)
        {
            for (int x = 0; x < 20; x++)
            {
                Instantiate(Resources.Load("Water"), new Vector3(xOff + (x * PADDING), yOff + (-y * PADDING), 0), Quaternion.identity);
            }
        }
    }
    void Redraw()
    {
        DestroyAll();

        for (int k = 0; k < ge.map.units.Length; k++)
        {
            if (ge.map.units[k] != null)
            {
                if (ge.map.units[k].Symbol == "H")
                {
                    Instantiate(Resources.Load("BabySharkH"), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -1), Quaternion.identity);
                    Instantiate(Resources.Load(DeterminHP(ge.map.units[k].Hp, ge.map.units[k].MaxHP)), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -2), Quaternion.identity);
                }
                else if (ge.map.units[k].Symbol == "R")
                {
                    Instantiate(Resources.Load("BabySharkR"), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -1), Quaternion.identity);
                    Instantiate(Resources.Load(DeterminHP(ge.map.units[k].Hp, ge.map.units[k].MaxHP)), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -2), Quaternion.identity);
                }

                else if (ge.map.units[k].Symbol == "h")
                {
                    Instantiate(Resources.Load("BabySharkH_Range"), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -1), Quaternion.identity);
                    Instantiate(Resources.Load(DeterminHP(ge.map.units[k].Hp, ge.map.units[k].MaxHP)), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -2), Quaternion.identity);
                }
                else if (ge.map.units[k].Symbol == "r")
                {
                    Instantiate(Resources.Load("BabySharkR_Range"), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -1), Quaternion.identity);
                    Instantiate(Resources.Load(DeterminHP(ge.map.units[k].Hp, ge.map.units[k].MaxHP)), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -2), Quaternion.identity);
                }
                else if (ge.map.units[k].Symbol == "C")
                {
                    Instantiate(Resources.Load("BabySharkH_Cute"), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -1), Quaternion.identity);
                    Instantiate(Resources.Load(DeterminHP(ge.map.units[k].Hp, ge.map.units[k].MaxHP)), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -2), Quaternion.identity);
                }
                else if (ge.map.units[k].Symbol == "c")
                {
                    Instantiate(Resources.Load("BabySharkR_Cute"), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -1), Quaternion.identity);
                    Instantiate(Resources.Load(DeterminHP(ge.map.units[k].Hp, ge.map.units[k].MaxHP)), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -2), Quaternion.identity);
                }
                else if (ge.map.units[k].Symbol == "A")
                {
                    Instantiate(Resources.Load("BabySharkH_Agro"), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -1), Quaternion.identity);
                    Instantiate(Resources.Load(DeterminHP(ge.map.units[k].Hp, ge.map.units[k].MaxHP)), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -2), Quaternion.identity);
                }
                else if (ge.map.units[k].Symbol == "a")
                {
                    Instantiate(Resources.Load("BabySharkR_Agro"), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -1), Quaternion.identity);
                    Instantiate(Resources.Load(DeterminHP(ge.map.units[k].Hp, ge.map.units[k].MaxHP)), new Vector3(xOff + (ge.map.units[k].XPos * PADDING), yOff + (-ge.map.units[k].YPos * PADDING), -2), Quaternion.identity);
                }
            }
        }
    }

    void DestroyAll()
    {
        GameObject[] killAllUnits = GameObject.FindGameObjectsWithTag("Redraw");
        foreach (GameObject unit in killAllUnits)
        {
            Destroy(unit);
        }
       
    }
    string DeterminHP(int hp, int maxHP)
    {
        string returnVal = "hp";
        double result = ((double)hp / (double)maxHP) * 20;
        int num = Mathf.CeilToInt((float)result);
        returnVal += num;
        return returnVal;
    }
}
