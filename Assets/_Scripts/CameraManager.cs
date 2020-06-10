using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject AimCanvas;
    public GameObject FirstPersonCamera, Camera;

    public bool isGunPicked;

    void Start()
    {
        AimCanvas.SetActive(false);
        isGunPicked = false;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            if (isGunPicked)
            {
            if (AimCanvas.activeInHierarchy)
            {
                AimCanvas.SetActive(false);
                FirstPersonCamera.SetActive(false);
                Camera.SetActive(true);
            }

            else if (!(AimCanvas.activeInHierarchy))
            {
                AimCanvas.SetActive(true);
                FirstPersonCamera.SetActive(true);
                Camera.SetActive(false);
            }
            }
            

            
        }

    }
}
