using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeScript : MonoBehaviour
{
    public GameObject LifeOne;
    public GameObject LifeTwo;
    public GameObject LifeThree;
    public GameObject GameOverPanel;
    private GameObject Player;
    public GameObject Camera;

    void Start()
    {
        Player = this.gameObject;
        LifeOne.SetActive(true);
        LifeTwo.SetActive(true);
        LifeThree.SetActive(true);
        GameOverPanel.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            if(LifeThree.activeInHierarchy == true)
            {
                LifeThree.SetActive(false);
            }
            else if(LifeTwo.activeInHierarchy == true)
            {
                LifeTwo.SetActive(false);
            }
            else if(LifeOne.activeInHierarchy == true)
            {
                LifeOne.SetActive(false);

                Player.SetActive(false);
                Camera.GetComponent<CameraFollow>().enabled = false;
                Cursor.lockState = CursorLockMode.None;
                GameOverPanel.SetActive(true);
            }
        }
    }
}
