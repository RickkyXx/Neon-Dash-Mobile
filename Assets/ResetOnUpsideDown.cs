using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetOnUpsideDown : MonoBehaviour
{
    public float upsideDownThreshold = 0.5f;
    private bool wasAboveCollider;
    private EdgeCollider2D edgeCollider;

    private void Start()
    {
        edgeCollider = GetComponent<EdgeCollider2D>();
    }
    void Update()
    {
        bool isAboveCollider = IsAboveCollider();

        if (wasAboveCollider && !isAboveCollider && IsUpsideDown())
        {
            ResetLevel();

        }

        wasAboveCollider = isAboveCollider;
    }

    bool IsAboveCollider()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);
        return hit.collider != null && hit.collider == edgeCollider;
    }
    bool IsUpsideDown()
    {
        return Vector3.Dot(transform.up, Vector3.down) > upsideDownThreshold;
    }

    void ResetLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
