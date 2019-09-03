using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerBehaviour : MonoBehaviour {

    public Transform tf;
    public Transform playertf;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float pos = playertf.position.z - 10;
        tf.position = new Vector3(0, 8, pos);
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name != "ground")
        {
            Debug.Log(collisionInfo.gameObject.name);
            Destroy(collisionInfo.gameObject);
        }
    }
}

    
