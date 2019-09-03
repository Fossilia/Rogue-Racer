using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollectablesCount : MonoBehaviour
{
    public Text collectablesText;
    public int count = 0;

    // Update is called once per frame
    void Update()
    {
        collectablesText.text = "Coins " + count.ToString();
    }
}
