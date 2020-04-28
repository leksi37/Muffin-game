using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float Health = 1000f;
    

    public void TakeDamage(float amount)
    {
        Health -= amount;
        if (Health == 0f)
            Die();
    }

    void Die()
    {
        if (gameObject.name == "Monster")
            GetComponentInParent<Animator>().SetBool("isKeeperDead", true);
        Destroy(gameObject);
        Debug.Log("Destroyed an enemy");
    }
}
