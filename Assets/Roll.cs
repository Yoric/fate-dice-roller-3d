using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{
    System.Random rand = new System.Random();

    // Start is called before the first frame update
    public void Start()
    {
        Rigidbody body = this.GetComponent<Rigidbody>();

        // Add a velocity, just to make it nice.
        body.velocity = new Vector3(
            -rand.Next(20),
            0,
            rand.Next(10) - 5
        );

        // Add a torque, to actually randomize the results.
        body.AddTorque(
            rand.Next(1000),
            rand.Next(1000),
            rand.Next(1000)
        );
    }

    void Reroll()
    {
        Rigidbody body = this.GetComponent<Rigidbody>();

        // Bounce up the die
        body.velocity = new Vector3(
            rand.Next(11) - 5,
            rand.Next(5) + 1,
            rand.Next(11) - 5
        );

        // Add a torque, to actually randomize the results.
        body.AddTorque(
            rand.Next(1000),
            rand.Next(1000),
            rand.Next(1000)
        );
    }
}
