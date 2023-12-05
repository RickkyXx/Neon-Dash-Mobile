using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{ // OnTriggerExit2D is called when the player exits the trigger area

    public GameManagerScript gameManager;
    private bool isDead;
    void OnTriggerExit2D(Collider2D other)
    {
        // Check if the exiting collider is the player
        if (other.CompareTag("Player"))
        {
            
            gameManager.gameOver();
            // Destroy the player GameObject
            Destroy(other.gameObject);
        }
    }
}
