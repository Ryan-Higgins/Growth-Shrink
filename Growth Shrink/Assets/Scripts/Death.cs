using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	Spawn mySpawnPoint;
	Transform levelSpawn;
	Move myMove;

	// Use this for initialization
	void Start () {
		mySpawnPoint = GetComponent<Spawn> ();
		levelSpawn = GameObject.Find ("Spawn").GetComponent<Transform> ();
		myMove = GetComponent<Move> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire2")) {
			if (mySpawnPoint.isPlaced) {
				transform.position = mySpawnPoint.spawnPoint;
				transform.localScale = new Vector3 (1, 1, 1);
				mySpawnPoint.isPlaced = false;
				mySpawnPoint.clone.SetActive (false);
				myMove.speed = 100;
				myMove.jumpDivider = 5;
			} else if (!mySpawnPoint.isPlaced) {
				transform.position = levelSpawn.position;
				transform.localScale = new Vector3 (1, 1, 1);
				myMove.speed = 100;
				myMove.jumpDivider = 5;
			}
		}
	}
}
