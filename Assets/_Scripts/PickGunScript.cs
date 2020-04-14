using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickGunScript : MonoBehaviour
{
    public GameObject GUIobj;
    public GameObject ToPick;
    public GameObject Picked;
    void Start()
    {
        GUIobj.SetActive(false);
        Picked.SetActive(false);
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GUIobj.SetActive(true);
            if (GUIobj.activeInHierarchy == true && Input.GetButtonDown("Equip"))
            {
                ToPick.SetActive(false);
                Picked.SetActive(true);
            }
        }    
    }
    // Update is called once per frame
    void OnTriggerExit()
    {
        GUIobj.SetActive(false);
    }
}
