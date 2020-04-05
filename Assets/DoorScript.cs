using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Animator DoorAnimator;
    public Collider collider;
    void Start()
    {
        DoorAnimator = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        other = collider;
        if (other.gameObject.tag == "Player")
        {
            DoorAnimator.SetBool("isOpen", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other = collider;
       // other.gameObject.GetComponent<Animator>().SetBool("isOpen", false);
        if(other.gameObject.tag =="Player")
        DoorAnimator.SetBool("isOpen", false);
    }
}
