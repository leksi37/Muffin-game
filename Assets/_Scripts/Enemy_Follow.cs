using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Follow : MonoBehaviour
{
    private NavMeshAgent Donut;
    public GameObject Player;
    public float DonutDistanceRun = 5f;

    void Start()
    {
        Donut = GetComponent<NavMeshAgent>();
        transform.LookAt(Player.transform);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);
        float distance = Vector3.Distance(transform.position, Player.transform.position); 
        
            //Make donut run to player


            Vector3 pathToPlayer = transform.position - Player.transform.position;

            Vector3 newPosition = transform.position - pathToPlayer;
            
            
            Donut.SetDestination(newPosition);
            
    }
}
