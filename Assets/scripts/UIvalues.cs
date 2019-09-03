using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIvalues : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    public float divider;

	// Update is called once per frame
	void Update () {
        float dividedDist = (player.position.z) / divider;
        scoreText.text = dividedDist.ToString("0");
	}
}
