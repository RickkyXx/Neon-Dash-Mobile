using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineManager : MonoBehaviour
{
    private GameObject currentLine;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider is a line (you may need to adjust the tag or layer)
        if (other.CompareTag("Line"))
        {
            // Destroy the previous line if it exists
            if (currentLine != null)
            {
                Destroy(currentLine);
            }

            // Set the new line as the current line
            currentLine = other.gameObject;
        }
    }
}
