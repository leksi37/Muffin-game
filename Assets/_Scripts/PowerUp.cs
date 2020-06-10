using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    private GameObject ToDestroy;
    [SerializeField]
    private GameObject ShootObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && ShootObject.GetComponent<Shoot>().isGunPicked == true)
        {
            ShootObject.GetComponent<Shoot>().dmg += 90;
            Debug.Log("Damage increased");


            Destroy(ToDestroy);
            Debug.Log(ToDestroy.name + " destroyed");
        }
    }
}
