using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portalScript : MonoBehaviour
{

    public Transform tf;
    public Transform playertf;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Player")
        {
            SceneManager.LoadScene("buildingZone"); //change scene
        }
    }
}


