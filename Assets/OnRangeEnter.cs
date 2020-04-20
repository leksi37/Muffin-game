using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OnRangeEnter : MonoBehaviour
{
    public NavMeshAgent navMesh;
  
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GetComponent<Animator>().SetBool("isInRange", true);
            navMesh.speed += 10f;
        }
    }

    public void OnTriggerLeave(Collider other)
    {
            GetComponent<Animator>().SetBool("isInRange", false);
            navMesh.speed -= 10f;
  
    }
}
