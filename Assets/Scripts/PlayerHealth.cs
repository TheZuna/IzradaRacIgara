using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    public int startingHealth = 100;                            
    public int currentHealth;                                   
    public Slider healthSlider;
    public Text gameOverText;                           


    bool isDead;


    void Awake()
    {
        gameOverText.enabled = false;

        // Set the initial health of the player.
        currentHealth = startingHealth;
    }


    public void TakeDamage(int amount)
    {

        // Reduce the current health by the damage amount.
        currentHealth -= amount;

        // Set the health bar's value to the current health.
        healthSlider.value = currentHealth;

        // If the player has lost all it's health and the death flag hasn't been set yet...
        if (currentHealth <= 0 && !isDead)
        {
            // ... it should die.
            Death();
        }
    }


    void Death()
    {
        // Set the death flag so this function won't be called again.
        isDead = true;

        gameOverText.enabled = true;

        this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | 
            RigidbodyConstraints.FreezeRotationY | 
            RigidbodyConstraints.FreezeRotationZ |
            RigidbodyConstraints.FreezePositionY | 
            RigidbodyConstraints.FreezePositionY | 
            RigidbodyConstraints.FreezePositionZ;
    }
}
