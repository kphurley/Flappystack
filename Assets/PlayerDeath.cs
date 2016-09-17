﻿using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour {

	public StateManager sm;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Wall") {
			Debug.Log ("DEATH");
			sm.StopGame ();
			Destroy (gameObject);
		}

	}
}
