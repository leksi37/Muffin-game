using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableFirstPersonCamera : MonoBehaviour
{
    public GameObject Player;
    void Start()
    {
        Player.GetComponent<CameraManager>().isGunPicked = true;
    }


}
