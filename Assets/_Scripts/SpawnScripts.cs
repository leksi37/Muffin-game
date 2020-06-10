using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.AI;

public class SpawnScripts : MonoBehaviour
{
    public GameObject Monster;
    public GameObject UpdateHouse;
    public GameObject Helper;
    public GameObject MainCharacter;

    public Transform WaterSpawn;
    public Transform MonsterSpawn;
    public Transform CandySpawn;
    public Transform WinterSpawn;

    private string MonsterPosition;
    private string PowerUpPosition;

void Start()
{
    GameObject[] spawnObjects = new GameObject[4];
    spawnObjects[0] = Monster;
    spawnObjects[1] = UpdateHouse;
    spawnObjects[2] = Helper;
    spawnObjects[3] = MainCharacter;

    Transform[] transforms = new Transform[4];
    transforms[0] = WaterSpawn;
    transforms[1] = MonsterSpawn;
    transforms[2] = CandySpawn;
    transforms[3] = WinterSpawn;

    System.Random r = new System.Random();
        for (int i = 0; i < 4; i++)
        {
            int randomNum = r.Next(0, 4);
            if (spawnObjects[randomNum] == null)
            {
                i--;
            }
            else
            {
                spawnObjects[randomNum].transform.position = transforms[i].position;
                if (randomNum == 0)
                {
                    //Name monster string for the Spitter Helper system
                    MonsterPosition = BaseSpawnedIn(i);

                    spawnObjects[randomNum].transform.position = new Vector3(spawnObjects[randomNum].transform.position.x, spawnObjects[randomNum].transform.position.y - 20f, spawnObjects[randomNum].transform.position.z);
                    Monster.GetComponent<NavMeshAgent>().enabled = true;
                    Monster.GetComponent<Enemy_Follow>().enabled = true;
                    Debug.Log("Spawned monster");
                }
                else if (randomNum == 1)
                {

                    PowerUpPosition = BaseSpawnedIn(i);
                    Debug.Log(PowerUpPosition);
                    Debug.Log("Spawned power up in " + PowerUpPosition);

                    if (i == 1 || i == 3)
                    {
                        spawnObjects[1].transform.Rotate(new Vector3(0, 180, 0));
                    }
                }

                else if (randomNum == 2)
                {
                    if (i == 1 || i == 3)
                    {
                        Helper.transform.Rotate(0f, -90f, 0f);
                    }
                    else
                    {
                        Helper.transform.Rotate(0f, 90f, 0f);
                    }
                    spawnObjects[randomNum].transform.position = new Vector3(spawnObjects[randomNum].transform.position.x, spawnObjects[randomNum].transform.position.y, spawnObjects[randomNum].transform.position.z);
                }

                if (randomNum == 3)
                {
                    spawnObjects[randomNum].transform.position = new Vector3(spawnObjects[randomNum].transform.position.x, spawnObjects[randomNum].transform.position.y + 5f, spawnObjects[randomNum].transform.position.z);
                }


                spawnObjects[randomNum] = null;
            }
        }
        GetComponent<SpitterHelperSystem>().SetHelp();
    }

    public string GetMonsterPosition()
    {
        return MonsterPosition;
    }

    public string GetPowerUpPosition()
    {
        return PowerUpPosition;
    }

    string BaseSpawnedIn(int num)
    {
        switch (num)
        {
            case 0:
                return "Water";
            case 1:
                return "Monster";
            case 2:
                return "Candy";
            case 3:
                return "Winter";
            default:
                Debug.Log("number is " + num);
                return "Something went wrong";
        }
    }
}