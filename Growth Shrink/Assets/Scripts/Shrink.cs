using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrink : MonoBehaviour {

	Transform player;
	Transform spawn;
	Move move;

	// Use this for initialization
	void Start () {
		//This finds the players and the spawns transforms
		player = GameObject.Find ("Player").GetComponent<Transform> ();
		spawn = GameObject.Find ("Spawn").GetComponent<Transform> ();
		move = GameObject.Find ("Player").GetComponent<Move> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			//resets the player's scale and position
			player.transform.localScale = new Vector3 (1, 1, 1);
			player.transform.position = new Vector3 (spawn.position.x, spawn.position.y, spawn.position.z);
			move.speed = 100;
		}
	}
}
