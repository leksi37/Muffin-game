using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public float dmg = 10f;
    public float range = 100f;
    public bool isAimScreenOn;
    public Camera camera;
    [SerializeField]
    private ParticleSystem Flash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetMouseButtonDown(0) && isAimScreenOn)
                Fire();

    }

    void Fire()
    {
        RaycastHit hit;
        Flash.Play();
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
                target.TakeDamage(dmg);

            Debug.Log("Hit a target");
        }


    }
}
