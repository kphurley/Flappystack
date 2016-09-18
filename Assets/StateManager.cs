using UnityEngine;
using System.Collections;
using System;

public class StateManager : MonoBehaviour {

	public bool gameIsRunning = false;
	public GameObject scenerySpawner;
	public GameObject player;
	public static GameObject canvas;

	// Use this for initialization
	void Start () {
		canvas = GameObject.FindGameObjectWithTag ("Canvas");
	}
	
	// Update is called once per frame
	void Update () {
	
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