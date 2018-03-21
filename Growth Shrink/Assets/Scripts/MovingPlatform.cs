using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

	GameObject left;
	GameObject right;
	float speed = 0.1f;

	// Use this for initialization
	void Start () {
		left = GameObject.Find ("Left");
		right = GameObject.Find ("Right");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x + speed,transform.position.y,transform.position.z);
	}

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Wall") {
			speed = -speed;
		}
	}
}
