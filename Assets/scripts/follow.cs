using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform t;
    public Vector3 offset;
    void Update()
    {
        transform.position = t.position + offset;
    }
}
