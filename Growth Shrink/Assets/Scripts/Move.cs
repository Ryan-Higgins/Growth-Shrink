using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Move : MonoBehaviour {

	Rigidbody2D myRB;
	Grow growScript;
	float h;
	public float speed;
	public bool grounded;
	public int jumpDivider;
	public float rayStart = 2.5f;
	public Animator myAnim;

	// Use this for initialization
	void Start () {
		myRB = GetComponent<Rigidbody2D> ();

		speed = 200;
		jumpDivider = 5;
		myAnim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		h = Input.GetAxis ("Horizontal");

		Vector3 jump = new Vector3 (0, speed, 0);
		Vector3 move = new Vector3 (h, 0, 0);

		myRB.AddForce (move * speed * 10);

		if (h > 0 || h < 0) {
			myAnim.SetBool ("IsMoving?", true);
		} else {
			myAnim.SetBool ("IsMoving?", false);
		}

		//Debug.DrawRay (new Vector3 (transform.position.x, transform.position.y-rayStart - transform.localScale.y / 2, transform.position.z), Vector3.down);
		//Debug.DrawRay (new Vector3 (transform.position.x  + transform.localScale.x*2, transform.position.y-rayStart - transform.localScale.y / 2, transform.position.z), Vector3.down);

		RaycastHit2D hit = Physics2D.Raycast (new Vector3 (transform.position.x, transform.position.y - rayStart - transform.localScale.y / 2, transform.position.z), Vector3.down, 0.01f);
		RaycastHit2D hitRight =  Physics2D.Raycast (new Vector3 (transform.position.x + transform.localScale.x *2, transform.position.y - rayStart - transform.localScale.y / 2, transform.position.z), Vector3.down, 0.01f);
		RaycastHit2D hitLeft =  Physics2D.Raycast (new Vector3 (transform.position.x - transform.localScale.x *2, transform.position.y - rayStart - transform.localScale.y / 2, transform.position.z), Vector3.down, 0.01f);

		if ((hit.collider != null && hit.collider.tag == "Floor") || (hitRight.collider != null && hitRight.collider.tag == "Floor") || (hitLeft.collider != null && hitLeft.collider.tag == "Floor") ) {
			grounded = true;
		} else { 
			grounded = false;
		}

		if (grounded == true && Input.GetButtonDown ("Jump")) {
			myRB.AddForce (jump * speed * 10 / jumpDivider);
		}

		if (grounded == false) {
			myAnim.SetBool ("Jumping", true);
		} else {
			myAnim.SetBool ("Jumping", false);
	}
}
}