using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGamePanel : MonoBehaviour
{
    [SerializeField]
    private GameObject EndPanel;
    [SerializeField]
    private GameObject Player;
    [SerializeField]
    private GameObject Camera;
    [SerializeField]
    private GameObject FPS;
    [SerializeField]
    private Animator DonutBodyAnimator;

    public void EndGame()
    {
        DonutBodyAnimator.SetBool("isDead", true);
        EndPanel.SetActive(true);
        Player.GetComponent<movementScript>().enabled = false;
        if (FPS.activeInHierarchy)
            FPS.SetActive(false);
        Camera.GetComponent<CameraFollow>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
