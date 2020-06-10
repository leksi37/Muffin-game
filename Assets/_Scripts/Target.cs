using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public float Health;
    public Slider Slider;    
    public void TakeDamage(float amount)
    {
        Health -= amount;
        Slider.value = Health;
        Debug.Log(Health + " health left.");
        if (Health == 0f)
            Die();
    }

    void Die()
    {
        if (gameObject.name == "Donut_Monster")
            GetComponent<EndGamePanel>().EndGame();
        Destroy(this.gameObject);
        Debug.Log("Destroyed an enemy");
    }

    
}
