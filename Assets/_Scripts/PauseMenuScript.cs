using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
    [SerializeField]
    private GameObject PausePanel;
    [SerializeField]
    private GameObject Camera;
    private Vector3 startingPosition;
    [SerializeField]
    private GameObject GameOver;

    void Start()
    {
        PausePanel.SetActive(false);
        GameOver.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown("p")) { 
            PausePanel.SetActive(true);
            GetComponent<movementScript>().enabled = false;
            Camera.GetComponent<CameraFollow>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
