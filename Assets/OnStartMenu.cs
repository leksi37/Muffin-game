using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStartMenu : MonoBehaviour
{
    public GameObject Options;

    // Start is called before the first frame update
    void Start()
    {
        Options.SetActive(false);
    }

}
