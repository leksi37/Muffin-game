using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Follow : MonoBehaviour
{
    private NavMeshAgent Donut;
    public GameObject Player;

    void Start()
    {
        Donut = GetComponent<NavMeshAgent>();

    }

    void Update()
    {
        Donut.speed = 35f;

        Vector3 pathToPlayer = transform.position - Player.transform.position;

        Vector3 newPosition = transform.position - pathToPlayer;
        Donut.SetDestination(newPosition);

        transform.LookAt(Player.transform);
    }
}
