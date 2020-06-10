using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDonutDieDoorActivate : MonoBehaviour
{
    [SerializeField]
    private GameObject Door;

    private void OnDestroy()
    {
        Door.GetComponent<BoxCollider>().enabled = true;
    }
}
