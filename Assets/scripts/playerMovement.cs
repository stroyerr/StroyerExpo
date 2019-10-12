using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float fDir = 150f;
    public float bDir = 70f;

    private void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, fDir * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -bDir * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, Time.deltaTime * -150, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, Time.deltaTime * 150, 0);
        }
    }
}





