using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeScript : MonoBehaviour
{
    public GameObject LifeOne;
    public GameObject LifeTwo;
    public GameObject LifeThree;
    public GameObject GameOverPanel;
    public GameObject Player;
    public GameObject Camera;

    void Start()
    {
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
                
                //Player.GetComponent<movementScript>().Speed = 0;
                //Player.GetComponent<movementScript>().Pivot = null;
                //Player.GetComponent<movementScript>().RotateSpeed=0;
                Player.SetActive(false);
                Camera.GetComponent<CameraFollow>().enabled = false;
                Cursor.lockState = CursorLockMode.None;
                GameOverPanel.SetActive(true);
            }
        }
    }

    //void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.tag == "Enemy")
    //    {
    //        StartCoroutine(Wait());
    //        if (LifeThree.activeInHierarchy == true)
    //        {
    //            LifeThree.SetActive(false);
    //        }
    //        else if (LifeTwo.activeInHierarchy == true)
    //        {
    //            LifeTwo.SetActive(false);
    //        }
    //        else if (LifeOne.activeInHierarchy == true)
    //        {
    //            LifeOne.SetActive(false);
    //            GameOverPanel.SetActive(true);
    //            Player.GetComponent<movementScript>().Speed = 0;
    //        }
    //    }
    //}

    //IEnumerator Wait()
    //{
    //    yield return new WaitForSeconds(5.0f);
    //}

}
