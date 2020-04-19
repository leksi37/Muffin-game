using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject Camera;
    private Vector3 startingPosition;
    public GameObject GameOver;
    void Start()
    {
        PausePanel.SetActive(false);
        GameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p")) { 
        //{
        //    startingPosition = Camera.transform.position;
        //    Camera.transform.position = new Vector3(startingPosition.x, 50f);
            PausePanel.SetActive(true);
            GetComponent<movementScript>().enabled = false;
            Camera.GetComponent<CameraFollow>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        //if (GameOver.active == true)
        //{
        //    GetComponent<movementScript>().enabled = false;
        //    Camera.GetComponent<CameraFollow>().enabled = false;
        //    Cursor.lockState = CursorLockMode.None;
        //    Cursor.visible = true;
        //}
    }
}
