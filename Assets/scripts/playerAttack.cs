using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour {

    public GameObject bullet;
    public Vector3 offset;
    public Vector3 speed;

	// Update is called once per frame
	void fixedUpdate () {
        if (Input.GetKey("space"))
        {
            Debug.Log("Shot");
            GameObject bulletClone;
            bulletClone = Instantiate(bullet, transform.position + offset, transform.rotation);
            Rigidbody bulletRb = bulletClone.GetComponent<Rigidbody>();
            bulletRb.velocity = transform.TransformDirection(speed);
        }
    }
}
