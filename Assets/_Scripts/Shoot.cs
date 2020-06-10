using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public bool isGunPicked;
    public float dmg = 10f;
    public float range = 100f;
    public bool isAimScreenOn;
    public Camera camera;
    [SerializeField]
    private ParticleSystem Flash;

    private void Start()
    {
        isGunPicked = false;
    }

    void Update()
    {
            if (Input.GetMouseButtonDown(0) && isAimScreenOn)
                Fire();
    }

    void Fire()
    {
        if (isGunPicked == false)
            isGunPicked = true;
        RaycastHit hit;
        Flash.Play();
        
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, range))
        {
            Debug.Log(hit.collider.gameObject.name);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(dmg);
                Debug.Log("Taken damage");
            }
            else
                Debug.Log("No Target component was found, Target = null");

            Debug.Log("Hit a target");
        }
    }
}
