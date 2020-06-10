using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickChomperScript : MonoBehaviour
{
    [SerializeField]
    private GameObject ChomperIcon;
    [SerializeField] 
    private GameObject PickUpCanvas;
    [SerializeField]
    private GameObject SpitterHelpCanvas;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PickUpCanvas.SetActive(true);
            if (Input.GetButtonDown("Equip"))
            {
                ChomperIcon.SetActive(true);
                SpitterHelpCanvas.SetActive(true);
                PickUpCanvas.SetActive(false);
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUpCanvas.SetActive(false);
    }
}
