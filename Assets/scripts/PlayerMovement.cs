using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float turnSpeed = 200;
    public int playerSpeed;
    public float rotationLimit = 0.2F;

    private int shootTimer = 50;
    private bool shot = false;

    public GameObject bullet;
    public Vector3 bulletOffset;

    public int upperLimit = 120;
    public int rightLimit = 200;
    public int leftLimit = -200;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate () {
        rb.AddForce(0, 0, playerSpeed*Time.deltaTime, ForceMode.VelocityChange);
        //transform.Rotate(0, 0, 0);

        if (shot)
        {
            shootTimer--;
        }

        if(shootTimer == 0)
        {
            shot = false;
            shootTimer = 50;
        }

        if (Input.GetKey("w") && transform.position.y < upperLimit) //up
        { 
            rb.AddForce(0, turnSpeed * Time.deltaTime, 0, ForceMode.VelocityChange);
            if(transform.rotation.x > -rotationLimit){
                transform.Rotate(Vector3.left);
            }    
            //rb.velocity = transform.TransformDirection(new Vector3(0,jumpForce,0));
            //jumpCheck = false;
        }
        else
        {
            if (transform.position.y >= upperLimit) //stops player from going beyond the limit
            {
                Vector3 temp = rb.velocity;
                temp.y = 0;
                rb.velocity = temp;

            }
            if (transform.rotation.x < 0)
            {
                transform.Rotate(Vector3.right);
            }
        }

        if (Input.GetKey("s")) //down
        { 
            rb.AddForce(0, -turnSpeed * Time.deltaTime, 0, ForceMode.VelocityChange);
            if (transform.rotation.x < rotationLimit)
            {
                transform.Rotate(Vector3.right);
            }
            //Debug.Log(transform.rotation.x);
            //rb.velocity = transform.TransformDirection(new Vector3(0,jumpForce,0));
            //jumpCheck = false;
        }
        else //adjust rotation back to 0
        {
            if (transform.rotation.x > 0)
            {
                transform.Rotate(Vector3.left);
            }
        }

        //Debug.Log(transform.position.x);
        if (Input.GetKey("d") && transform.position.x < rightLimit) //right
        {
            rb.AddForce(turnSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            if (transform.rotation.z > -rotationLimit)
            {
                transform.Rotate(Vector3.back);
            }
        }
        else 
        {
            if (transform.position.x >= rightLimit) //stops player from going beyond the limit
            {
                Vector3 temp = rb.velocity;
                temp.x = 0;
                rb.velocity = temp;

            }
            if (transform.rotation.z < 0) //adjust rotation back to 0
            {
                transform.Rotate(Vector3.forward);
            }
        }
        if (Input.GetKey("a") && transform.position.x > leftLimit) //left
        {
            rb.AddForce(-turnSpeed*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            if (transform.rotation.z < rotationLimit)
            {
                transform.Rotate(Vector3.forward);
            }
        }
        else 
        {
            if (transform.position.x <= leftLimit) //stops player from going beyond the limit
            {
                Vector3 temp = rb.velocity;
                temp.x = 0;
                rb.velocity = temp;

            }
            if (transform.rotation.z > 0) //adjust rotation back to 0
            {
                transform.Rotate(Vector3.back);
            }
        }

        if (Input.GetKey("space") && !shot)
        {
            Debug.Log("Shot");
            Instantiate(bullet, transform.position + bulletOffset, bullet.transform.rotation);
            shot = true;
        }

        if (!Input.anyKey) //stabilizes the planes y axis rotation
        {
            if (transform.rotation.y > 0.01)
            {
                transform.Rotate(Vector3.down);
            }
            else if (transform.rotation.y < -0.01)
            {
                transform.Rotate(Vector3.up);
            }
        }
    }
}
