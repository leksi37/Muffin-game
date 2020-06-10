using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OnRangeEnter : MonoBehaviour
{
    
    public NavMeshAgent navMesh;
  
    public void OnTriggerStay(Collider other)
    {
       
        if(other.tag == "Player")
        { 
            StartCoroutine(WaitBeforeChase());
            Debug.Log("Coroutine over start chase");

            GetComponent<Animator>().SetBool("isInRange", true);
            navMesh.speed += 20f;
            navMesh.acceleration += 15f;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            GetComponent<Animator>().SetBool("isInRange", false);
            navMesh.speed -= 20f;
            navMesh.acceleration -= 15f;
        }  
    }

    IEnumerator WaitBeforeChase()
    {
        yield return new WaitForSeconds(5f);
    }
}
