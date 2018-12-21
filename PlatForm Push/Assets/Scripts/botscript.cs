using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botscript : MonoBehaviour
{
    public GameObject Target;
    public float speed = 10;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Vector3 movement = (Target.transform.position - transform.position).normalized * speed;
        rb.AddForce(movement);
    }
}
