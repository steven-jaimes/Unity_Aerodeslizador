using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float speed = 10.0f;
    public float tiltAngle = 10.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float straffe = Input.GetAxis("Horizontal") * speed;
        straffe *= Time.deltaTime;

        Vector3 movement = new Vector3(straffe, 0.0f, speed * Time.deltaTime);
        rb.AddForce(movement * speed);

        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * speed);
    }
}