using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour {

	public float growthIncrease;
	public float growthLimit;
	Move move;

	// Use this for initialization
	void Start () {
		move = GetComponent<Move> ();

		//Ensuring values always have a default if not set in editor
		if (growthIncrease == 0) {
			growthIncrease = 1;
		}

		if (growthLimit == 0) {
			growthLimit = 5;
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D cube) {
		//Cube will destroy itself even if the player doesn't grow
		if (cube.tag == "Grow") {
			Destroy (cube.gameObject);
			//checks the player is below the limit(if we want one) and grows them if they are below
			if (transform.localScale.x <= growthLimit && transform.localScale.y <= growthLimit) {
				transform.localScale += new Vector3(growthIncrease,growthIncrease,0);
				//Adds speed each time so that the player can actually keep moving
				move.speed += 200;
				move.jumpDivider += 5;
			}
		}
	}
}
