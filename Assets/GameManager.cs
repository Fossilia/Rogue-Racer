using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public PlayerMovement Player;

	public void StartGame()
    {
        SceneManager.LoadScene("Scenes/Zone1");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Scenes/Menu");
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("Scenes/Game Over");
    }
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
