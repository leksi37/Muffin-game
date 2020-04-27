using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomSpawns : MonoBehaviour
{
    public GameObject Gun;
    public GameObject Chomper;

    void Start()
    { 
    //Chomper.transform.position = new Vector3(-84f, -26.767f, 350f);
        
        Chomper.transform.position = new Vector3(Chomper.transform.position.x + Random.Range(-500f, 500f), Chomper.transform.position.y, Chomper.transform.position.z + Random.Range(-300f, 300f));
        Debug.Log(Chomper.transform.position.x + ", " + Chomper.transform.position.y + ", " + Chomper.transform.position.z);

        Gun.transform.position = new Vector3(Gun.transform.position.x + Random.Range(-400f, 400f), Gun.transform.position.y, Gun.transform.position.z + Random.Range(-200f, 200f));
        Debug.Log(Gun.transform.position.x + ", " + Gun.transform.position.y + ", " + Gun.transform.position.z);


        Chomper.GetComponent<NavMeshAgent>().enabled = true;
    }
}  










//    GameObject[] spawnObjects = new GameObject[2];
   // Vector3[] positions = new Vector3[10];

       // spawnObjects[0] = Gun;
        //spawnObjects[1] = Chomper;

        //positions[0] = new Vector3(-84f, -26.767f, 350f);
        //positions[1] = new Vector3(1953f, -26.75f, -500f);
        //positions[2] = new Vector3(1587f, -26.73f, -2240f);
        //positions[3] = new Vector3(197.83f, -7.2f, -1205.63f);
        //positions[4] = new Vector3(-275.71f, 83.16f, -556.47f);



//    Debug.Log(Chomper.transform.position.x + ", " + Chomper.transform.position.y + ", " + Chomper.transform.position.z);
        //}
        //else if (randomNum == 2)
        //{
        //    Chomper.transform.position = positions[2];
        //    Chomper.transform.position = new Vector3(Chomper.transform.position.x + Random.Range(-300f, 300f), Chomper.transform.position.y, Chomper.transform.position.z + Random.Range(-200f, 200f));
        //    Debug.Log(Chomper.transform.position.x + ", " + Chomper.transform.position.y + ", " + Chomper.transform.position.z);
        //}
        //else if (randomNum == 3)
        //{
        //    Chomper.transform.SetPositionAndRotation(positions[3], new Quaternion(0,Random.Range(0,180),0,0));
        //    Debug.Log(Chomper.transform.position.x + ", " + Chomper.transform.position.y + ", " + Chomper.transform.position.z);
        //}
        //else if (randomNum == 4)
        //{
        //    Chomper.transform.SetPositionAndRotation(positions[4], new Quaternion(0, Random.Range(0, 180), 0, 0));
        //    Debug.Log(Chomper.transform.position.x + ", " + Chomper.transform.position.y + ", " + Chomper.transform.position.z);
        //}


        //int randomGun = Random.Range(5, 10);
        //if(randomGun == 5)
        //{
        //    Gun.transform.position = positions[5];
        //}
        //else if (randomGun == 6)
        //{
        //    Gun.transform.position = positions[6];
        //}
        //else if (randomGun == 7)
        //{
        //    Gun.transform.position = positions[7];
        //}
        //else if (randomGun == 8)
        //{
        //    Gun.transform.position = positions[8];
        //}
        //else if (randomGun == 9)
        //{
        //    Gun.transform.position = positions[9];
        //}