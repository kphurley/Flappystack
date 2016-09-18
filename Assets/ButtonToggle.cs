using UnityEngine;
using System.Collections;

public class ButtonToggle : MonoBehaviour {

	private GameObject restartButton;
	public bool isActive = true;

	// Use this for initialization
	void Start () {
		restartButton = GameObject.FindGameObjectWithTag ("Restart");
	}
	
	public void ToggleButton(){
		isActive = !isActive;
		if (isActive) {
			restartButton.transform.localPosition += 5.0f * Vector3.up;
		}
		else{
			restartButton.transform.localPosition += 5.0f * Vector3.down;
		}
	}

}
