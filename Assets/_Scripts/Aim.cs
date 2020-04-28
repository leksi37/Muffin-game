using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public GameObject AimCanvas;
    public GameObject Camera, AimArm;
    public GameObject RightFoot, LeftFoot, LeftHand, RightHand, AttachedGun;
    public Animator animator;

    public bool isAimScreenOn;

    void Start()
    {
        AimCanvas.SetActive(false);
        isAimScreenOn = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            if (AimCanvas.activeInHierarchy)
            {
                AimCanvas.SetActive(false);
                Camera.GetComponent<CameraFollow>().isZoom = false;
                transform.GetComponent<MeshRenderer>().enabled = true;
                LeftFoot.GetComponent<MeshRenderer>().enabled = true;
                RightFoot.GetComponent<MeshRenderer>().enabled = true;
                RightHand.GetComponent<MeshRenderer>().enabled = true;
                LeftHand.GetComponent<MeshRenderer>().enabled = true;
                AttachedGun.SetActive(true);

                AimArm.SetActive(false);
                isAimScreenOn = false;
            }
            // && AttachedGun.activeInHierarchy
            else if (!(AimCanvas.activeInHierarchy) )
            {
                AimCanvas.SetActive(true);
                Camera.GetComponent<CameraFollow>().isZoom = true;
                transform.GetComponent<MeshRenderer>().enabled = false;
                LeftFoot.GetComponent<MeshRenderer>().enabled = false;
                RightFoot.GetComponent<MeshRenderer>().enabled = false;
                RightHand.GetComponent<MeshRenderer>().enabled = false;
                LeftHand.GetComponent<MeshRenderer>().enabled = false;
                AttachedGun.SetActive(false);

                AimArm.SetActive(true);
                isAimScreenOn = true;
            }

            
        }

    }
}
