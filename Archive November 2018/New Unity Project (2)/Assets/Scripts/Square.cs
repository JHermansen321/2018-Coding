﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    [SerializeField]
    GameObject ballPrefab;
    float speed = 2f;

    // Use this for initialization
    void Start()
    {
        
    }
    Vector3 velocity = new Vector3(0, 0, 0);
    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + 365 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z - 365 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            velocity += LookAtDirection(transform.eulerAngles.z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity -= LookAtDirection(transform.eulerAngles.z);
        }
        velocity.Normalize();
        transform.position += velocity * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject newball = Instantiate(ballPrefab);
            newball.transform.position = transform.position;
            newball.GetComponent<Ball>().velocity = LookAtDirection(transform.eulerAngles.z);
        }
    }
    void MovementWASD()
    {

        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y < 1)
                velocity += Vector3.up;
        }


        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -1)
                velocity += Vector3.down;
        }



        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -1.75f)
                velocity += Vector3.left;
        }



        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 1.75f)
                velocity += Vector3.right;
        }        
    }
    public Vector3 LookAtDirection(float eulerAnglesZ)
    {
        return new Vector3(Mathf.Cos(eulerAnglesZ * Mathf.Deg2Rad), Mathf.Sin(eulerAnglesZ * Mathf.Deg2Rad), 0);
    }

}
