using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(player)
			transform.position = new Vector3 (player.position.x, 0, -10);
		
	}
}
