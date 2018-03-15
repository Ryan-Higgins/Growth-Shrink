using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	Rigidbody2D myRB;
	Grow growScript;
	float h;
	public float speed;
	public bool grounded;
	public int jumpDivider;

	// Use this for initialization
	void Start () {
		myRB = GetComponent<Rigidbody2D> ();

		speed = 200;
		jumpDivider = 5;
	}
	
	// Update is called once per frame
	void Update () {
		h = Input.GetAxis ("Horizontal");

		Vector3 jump = new Vector3 (0, speed, 0);
		Vector3 move = new Vector3 (h, 0, 0);

		myRB.AddForce (move * speed*10);
		//Debug.DrawRay (new Vector3 (transform.position.x, transform.position.y-2.5f - transform.localScale.y / 2, transform.position.z), Vector3.down);
		RaycastHit2D hit = Physics2D.Raycast (new Vector3 (transform.position.x, transform.position.y - 2.5f - transform.localScale.y / 2, transform.position.z), Vector3.down, 0.01f);

		if (hit.collider != null) {
			grounded = true;
		} else { 
			grounded = false;
		}

		if (grounded == true && Input.GetButtonDown ("Jump")) {
			myRB.AddForce (jump * speed*10 / jumpDivider);
		}
	}
}