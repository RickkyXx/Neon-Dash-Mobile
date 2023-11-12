using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    bool move = false;

    public Rigidbody2D rb;

    public float speed = 20f;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            move = true;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            move = false;
        }
    }

    private void FixedUpdate()
    {
        if (move == true)
        {
            rb.AddForce(transform.right * speed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
        }
    }
}
