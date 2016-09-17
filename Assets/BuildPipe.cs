using UnityEngine;
using System.Collections;

public class BuildPipe : MonoBehaviour {

	public GameObject pipeTile;
	public int pipeLength = 10;

	// Use this for initialization
	void Start () {
		SpawnPipe ();
	}

	void SpawnPipe() {
		int bottomLength = Random.Range (0, pipeLength);
		int topLength = pipeLength - bottomLength;
		float bottomY = -4f;
		for (int i = 0; i < bottomLength; i++) {
			GameObject gObj = Instantiate (pipeTile) as GameObject;
			gObj.transform.SetParent (this.transform);
			gObj.transform.localPosition = new Vector3 (0f, bottomY, 0f);
			bottomY += 0.6f;
		}
		float topY = 4.4f;
		for (int j = 0; j < topLength; j++) {
			GameObject gObj = Instantiate (pipeTile) as GameObject;
			gObj.transform.SetParent (this.transform);
			gObj.transform.localPosition = new Vector3 (0f, topY, 0f);
			topY -= 0.6f;
		}
	}
	

}
