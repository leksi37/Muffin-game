using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject AimCanvas;
    public GameObject FirstPersonCamera, Camera;
    public GameObject RightFoot, LeftFoot, LeftHand, RightHand, AttachedGun;
    public Animator animator;

    public bool isGunPicked;

    void Start()
    {
        AimCanvas.SetActive(false);
        isGunPicked = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            if (isGunPicked)
            {
            if (AimCanvas.activeInHierarchy)
            {
                AimCanvas.SetActive(false);
                transform.GetComponent<MeshRenderer>().enabled = true;
                LeftFoot.GetComponent<MeshRenderer>().enabled = true;
                RightFoot.GetComponent<MeshRenderer>().enabled = true;
                RightHand.GetComponent<MeshRenderer>().enabled = true;
                LeftHand.GetComponent<MeshRenderer>().enabled = true;
                AttachedGun.SetActive(true);
                FirstPersonCamera.SetActive(false);
                Camera.SetActive(true);
            }
            // && AttachedGun.activeInHierarchy
            else if (!(AimCanvas.activeInHierarchy) )
            {
                AimCanvas.SetActive(true);
                transform.GetComponent<MeshRenderer>().enabled = false;
                LeftFoot.GetComponent<MeshRenderer>().enabled = false;
                RightFoot.GetComponent<MeshRenderer>().enabled = false;
                RightHand.GetComponent<MeshRenderer>().enabled = false;
                LeftHand.GetComponent<MeshRenderer>().enabled = false;
                AttachedGun.SetActive(false);

                FirstPersonCamera.SetActive(true);
                Camera.SetActive(false);
            }
            }
            

            
        }

    }
}
