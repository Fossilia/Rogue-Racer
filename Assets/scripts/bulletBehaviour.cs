using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehaviour : MonoBehaviour {
    public Rigidbody rb;
    public Vector3 speed;

    private void Start()
    {
        //rb.velocity = transform.TransformDirection(speed);
    }
    // Update is called once per frame
    void Update () {
        rb.AddForce(speed * Time.deltaTime);
        //rb.velocity = transform.TransformDirection(speed);
    }
}
