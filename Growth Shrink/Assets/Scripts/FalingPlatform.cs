using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalingPlatform : MonoBehaviour {

	Rigidbody2D myRB;

	// Use this for initialization
	void Start () {
		myRB = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionExit2D (Collision2D other) {
		if (other.gameObject.tag == "Player") {
			myRB.gravityScale = 1;
			myRB.freezeRotation = false;
			myRB.constraints = RigidbodyConstraints2D.None;
		}
	}
}
