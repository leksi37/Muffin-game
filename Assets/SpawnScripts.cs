using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnScripts : MonoBehaviour
{
    public GameObject Monster;
    public GameObject UpdateHouse;
    public GameObject Helper;

    public Transform WaterPos;
    public Transform MonsterPos;
    public Transform ForestPos;
    void Start()
    {
        GameObject[] spawnObjects = new GameObject[3];
        spawnObjects[0] = Monster;
        spawnObjects[1] = UpdateHouse;
        spawnObjects[2] = Helper;

        Transform[] transforms = new Transform[3];
        transforms[0] = WaterPos;
        transforms[1] = MonsterPos;
        transforms[2] = ForestPos;

        //Vector3 MonsterPosition = new Vector3(1541f, 55f, 1673f);
        //Vector3 Position = new Vector3(1541f, 55f, 1673f);
        //Vector3 WaterPosition = new Vector3(1541f, 55f, 1673f);

        System.Random r = new System.Random();
        for(int i =0; i < 3; i++)
        {
            int randomNum = r.Next(0, 3);
            if(spawnObjects[randomNum] == null)
            {
                i--;
            }
            else
            {
                if(i == 1)
                {
                    spawnObjects[randomNum].transform.Rotate(0f, 180f, 0f);
                }
                spawnObjects[randomNum].transform.position = transforms[i].position;
                spawnObjects[randomNum] = null;
            }

        }
    }
}
