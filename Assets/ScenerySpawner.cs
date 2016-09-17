using UnityEngine;
using System.Collections;

public class ScenerySpawner : MonoBehaviour {

	public GameObject sceneryPrefab;
	public float spawnTimer = 5.0f;
	public float xLoc = 0f;
	public GameObject pipeSet;
	public GameObject player;

	// Use this for initialization
	void Start () {
		SpawnScenery ();
	}
	
	void SpawnScenery() {
		Instantiate (sceneryPrefab, new Vector3 (xLoc, 0f, 0f), Quaternion.identity);

		Instantiate (pipeSet, new Vector3(xLoc, 0f, 0f), Quaternion.identity);
		Instantiate (pipeSet, new Vector3(xLoc+5f, 0f, 0f), Quaternion.identity);

		xLoc += 10f;
		if(player) Invoke("SpawnScenery", spawnTimer);
	}
}
