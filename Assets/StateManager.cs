using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class StateManager : MonoBehaviour {

	public bool gameIsRunning = false;
	public GameObject scenerySpawner;
	public GameObject player;
	public static GameObject canvas;
	public Text scoreText;
	public int score = 0;

	// Use this for initialization
	void Start () {
		canvas = GameObject.FindGameObjectWithTag ("Canvas");

	}
	
	// Update is called once per frame
	void Update () {

		// This is how I am implementing keeping score
		if (GameObject.FindGameObjectWithTag ("Player")) {
			player = GameObject.FindGameObjectWithTag ("Player");
			if(player.transform.position.x > 10)
				score = (int)( Math.Floor (player.transform.position.x / 5 - 1));
			scoreText.text = " " + score;
		}
			
	}

	public void StartGame() {
		gameIsRunning = true;
		Instantiate (scenerySpawner);
		Instantiate (player);
		canvas.SetActive(false);
	}

	public void StopGame() {
		gameIsRunning = false;
		canvas.SetActive (true);
		GameObject[] sceneryArray = GameObject.FindGameObjectsWithTag ("Scenery");
		Action<GameObject> destroyScenery = new Action<GameObject>(DestroyScenery);
		Array.ForEach(sceneryArray, destroyScenery);

	}

	public void DestroyScenery(GameObject scenery){
		Destroy (scenery);
	}

}