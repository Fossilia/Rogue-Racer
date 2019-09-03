using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour {

    public PlayerMovement movement;
    public CollectablesCount collectablesCount;
    public Rigidbody rb;
    //public int collectablesCount = 0;
    
    void GameOver()
    {
        FindObjectOfType<GameManager>().LoadGameOver();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            rb.useGravity = true;
            rb.AddForce(4 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            Invoke("GameOver", 3f);
        }
        if (collisionInfo.collider.tag == "collectable")
        {
            Debug.Log("hit collect");
            Destroy(collisionInfo.gameObject);
            collectablesCount.count += 1;
        }
    }

}
