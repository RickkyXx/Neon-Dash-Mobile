using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Diamond : MonoBehaviour
{
    [SerializeField] private int value = 10;
    public TextMeshProUGUI scoreTextPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DisplayScoreText();
            DiamondManager.instance.AddDiamonds(value);
            Destroy(gameObject);
        }
    }

    private void DisplayScoreText()
    {
        // Instantiate the score text prefab
        TextMeshProUGUI scoreTextInstance = Instantiate(scoreTextPrefab);

        // Set the position of the score text to the position of the collectible
        scoreTextInstance.rectTransform.position = Camera.main.WorldToScreenPoint(transform.position);

        // Set the parent of the score text instance to the Canvas
        scoreTextInstance.transform.SetParent(GameObject.FindWithTag("Canvas").transform, true);

        // Set the score text value
        scoreTextInstance.text = "+" + value;

        // Destroy the score text after a short delay (you can adjust the delay as needed)
        Destroy(scoreTextInstance.gameObject, 1.0f);
    }
}
