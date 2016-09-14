using UnityEngine;
using System.Collections;

public class ScenerySpawner : MonoBehaviour {

	public GameObject sceneryPrefab;
	public float spawnTimer = 10.0f;
	public float xLoc = 0f;

	// Use this for initialization
	void Start () {
		SpawnScenery ();
	}
	
	void SpawnScenery() {
		Instantiate (sceneryPrefab, new Vector3 (xLoc, 0f, 0f), Quaternion.identity);
		Instantiate (sceneryPrefab, new Vector3 (xLoc+10f, 0f, 0f), Quaternion.identity);
		xLoc += 10f;
		Invoke("SpawnScenery", spawnTimer);
	}
}
