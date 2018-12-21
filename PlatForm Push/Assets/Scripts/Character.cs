using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed;

    public float boost;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            moveHorizontal *= boost;
            moveVertical *= boost;
        }
        Vector3 movement = new Vector3(speed *moveHorizontal, 0.0f, speed * moveVertical);
        rb.AddForce(movement);
    }
    
}
