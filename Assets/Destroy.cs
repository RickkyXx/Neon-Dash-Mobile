using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{
    private void OnCollisionExit2D(Collision2D collision)
    {
        // Check if the collider leaving the line has the "Player" tag
        if (collision.collider.CompareTag("Player"))
        {
            // Destroy the Line (or the GameObject containing the EdgeCollider2D)
            Destroy(gameObject);
        }
    }
}
