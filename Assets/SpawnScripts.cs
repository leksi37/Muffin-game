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
    public GameObject Gun;

    public Transform WaterPos;
    public Transform MonsterPos;
    public Transform ForestPos;
    public Transform SnowPos;
    void Start()
    {
        GameObject[] spawnObjects = new GameObject[4];
        spawnObjects[0] = Monster;
        spawnObjects[1] = UpdateHouse;
        spawnObjects[2] = Helper;
        spawnObjects[3] = Gun;

        Transform[] transforms = new Transform[4];
        transforms[0] = WaterPos;
        transforms[1] = MonsterPos;
        transforms[2] = ForestPos;
        transforms[3] = SnowPos;

        //Vector3 MonsterPosition = new Vector3(1541f, 55f, 1673f);
        //Vector3 Position = new Vector3(1541f, 55f, 1673f);
        //Vector3 WaterPosition = new Vector3(1541f, 55f, 1673f);

        System.Random r = new System.Random();
        for(int i =0; i < 4; i++)
        {
            int randomNum = r.Next(0, 4);
            if(spawnObjects[randomNum] == null)
            {
                i--;
            }
            else
            { 
                spawnObjects[randomNum].transform.position = transforms[i].position;
                if(randomNum == 0)
                {
                    
                    spawnObjects[randomNum].transform.position = new Vector3(spawnObjects[randomNum].transform.position.x, spawnObjects[randomNum].transform.position.y -20f, spawnObjects[randomNum].transform.position.z);
                    Monster.GetComponent<NavMeshAgent>().enabled = true;
                    Monster.GetComponent<Enemy_Follow>().enabled = true;
                    Debug.Log("Spawned monster");
                }
                else if (i == 1)
                {
                    spawnObjects[randomNum].transform.Rotate(0f, 180f, 0f);
                }
                
                else if(randomNum == 2)
                {
                    if(i == 1 || i == 3)
                    {
                        Helper.transform.Rotate(0f, -90f, 0f);
                    }
                    else
                    {
                        Helper.transform.Rotate(0f, 90f, 0f);
                    }
                    spawnObjects[randomNum].transform.position = new Vector3(spawnObjects[randomNum].transform.position.x , spawnObjects[randomNum].transform.position.y, spawnObjects[randomNum].transform.position.z );
                }

                if (randomNum == 3)
                {
                    spawnObjects[randomNum].transform.position = new Vector3(spawnObjects[randomNum].transform.position.x, spawnObjects[randomNum].transform.position.y + 5f, spawnObjects[randomNum].transform.position.z);
                }

                
                spawnObjects[randomNum] = null;
            }

        }
    }
}
