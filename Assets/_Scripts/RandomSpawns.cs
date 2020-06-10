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
        Chomper.transform.position = new Vector3(Chomper.transform.position.x + Random.Range(-500f, 500f), Chomper.transform.position.y, Chomper.transform.position.z + Random.Range(-300f, 300f));
        Debug.Log(Chomper.transform.position.x + ", " + Chomper.transform.position.y + ", " + Chomper.transform.position.z);

        Gun.transform.position = new Vector3(Gun.transform.position.x + Random.Range(-400f, 400f), Gun.transform.position.y, Gun.transform.position.z + Random.Range(-200f, 200f));
        Debug.Log(Gun.transform.position.x + ", " + Gun.transform.position.y + ", " + Gun.transform.position.z);

        //Chomper.GetComponent<NavMeshAgent>().enabled = true;
    }
}  
