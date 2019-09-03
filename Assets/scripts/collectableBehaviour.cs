using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableBehaviour : MonoBehaviour {

    public Transform collectable;
    public CollectablesCount collectablesCount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        collectable.Rotate(Vector3.up*3);
    }
}

