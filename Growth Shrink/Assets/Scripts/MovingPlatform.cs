using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

	float speed = 0.1f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x + speed,transform.position.y,transform.position.z);
	}

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Platform Wall") {
			speed = -speed;
		}
		if (other.gameObject.tag == "Player" || other.gameObject.tag == "Spawn") {
			other.transform.parent = gameObject.transform;
		}
	}

	void OnCollisionExit2D(Collision2D other) {
		if (other.gameObject.tag == "Player" || other.gameObject.tag == "Spawn") {
			other.transform.parent = GameObject.Find ("Platform Fix").transform;
		}
	}
}
