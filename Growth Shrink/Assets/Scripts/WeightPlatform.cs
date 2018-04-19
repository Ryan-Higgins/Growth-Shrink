using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightPlatform : MonoBehaviour {

	public Vector3 startPosition;
	bool playerOn;

	// Use this for initialization
	void Start () {
		startPosition = gameObject.transform.position; 
	}
	
	// Update is called once per frame
	void Update () {
		if (!playerOn) {
			transform.position = Vector3.Lerp (gameObject.transform.position, startPosition, 0.1f);
		}

	}

	void OnCollisionExit2D(Collision2D other) {
		if (other.gameObject.tag == "Player") {
			playerOn = false;	
		}
	}

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Player") {
			playerOn = true;
		}
	}
}
