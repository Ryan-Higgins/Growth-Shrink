using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour {

	Transform player;
	public float growthSpeed;
	public float growthLimit;
	Move move;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player").GetComponent<Transform> ();
		move = GameObject.Find ("Player").GetComponent<Move> ();

	}
	
	// Update is called once per frame
	void Update () {
		//grows the player to a limit set from the inspector
		if (player.localScale.x <= growthLimit) {
			player.transform.localScale += new Vector3 (growthSpeed * Time.deltaTime, growthSpeed * Time.deltaTime, 0);
			move.speed += growthSpeed;
		}
	}
}
