using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody ballRb;
    public float forcePower;

    private void Start()
    {
        ballRb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        ballRb.velocity=Vector3.down*forcePower;
    }
}
