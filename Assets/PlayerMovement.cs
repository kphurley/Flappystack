using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 0.5f;
	public float jumpPower = 5f;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			rb.AddForce (jumpPower * Vector2.up, ForceMode2D.Impulse);
		} else {
			transform.position += speed*(Vector3.right);
		}



	}
}
