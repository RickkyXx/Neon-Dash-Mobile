using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform targets;
    public Vector3 offset;

    private void Start()
    {
        // Find the car GameObject by tag (you may need to adjust the tag)
        GameObject car = GameObject.FindGameObjectWithTag("Player");

        // Assign the car's transform to the targets variable
        if (car != null)
        {
            targets = car.transform;
        }
        else
        {
            Debug.LogError("Car GameObject not found. Make sure it has the correct tag.");
        }
    }

    private void LateUpdate()
    {
        // Check if the targets object is not null before accessing its position
        if (targets != null)
        {
            Vector3 newPos = targets.position + offset;
            newPos.z = transform.position.z;

            transform.position = newPos;
        }
    }
}
