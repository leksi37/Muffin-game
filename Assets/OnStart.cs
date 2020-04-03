using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStart : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject EnemyDonut;
    public GameObject Gun;
    public GameObject UpdateHouse;
    public GameObject Helper;
    private Vector3 MonsterSpawn = new Vector3(2570f, 93f, 1448f);
    private Vector3 LeftForestSpawn = new Vector3(2570f, 93f, 1448f);
    private Vector3 RightForestSpawn = new Vector3(2570f, 93f, 1448f);
    private Vector3 CenterForestSpawn = new Vector3(2570f, 93f, 1448f);


    void Start()
    {

        //SpawnGun();
        //SpawnHelper();
        //SpawnUpdateHouse();

        //yield return new WaitForSeconds(60f);
        //SpawnEnemyDonut();
    }

    private void SpawnGun()
    {
     
    }
}
