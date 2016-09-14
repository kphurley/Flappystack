using UnityEngine;
using System.Collections;

public class DeleteTimer : MonoBehaviour {

	public float lifeTime = 3.0f;
	private float deathTime;

	// Use this for initialization
	void Start () {
		deathTime = lifeTime + Time.fixedTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.fixedTime >= deathTime) {
			Destroy (gameObject);
		}
	}
}
