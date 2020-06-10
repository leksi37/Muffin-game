using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickGunScript : MonoBehaviour
{
    public GameObject GUIobj;
    public GameObject ToPick;
    public GameObject Picked;
    public GameObject Cupcacke;

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
                GUIobj.SetActive(false);
                Picked.SetActive(true);
                Cupcacke.GetComponent<CameraManager>().isGunPicked = true;
                Destroy(ToPick);
            }
        }    
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            GUIobj.SetActive(false);
    }
}
