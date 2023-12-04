using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{
    public EdgeCollider2D edgeCollider;

    private void Update()
    {
        if (!IsCarInsideCollider())
        {
            Destroy(edgeCollider.gameObject);
        }
    }
    bool IsCarInsideCollider()
    {
        Vector2 carPosition = transform.position;

        return edgeCollider.OverlapPoint(carPosition);
    }
}
