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
		if (Input.GetAxis ("Spawn") == 1) {
			if (mySpawnPoint.firstPlaced) {
				transform.position = mySpawnPoint.spawnPoint1;
				mySpawnPoint.firstPlaced = false;
				mySpawnPoint.clone1.SetActive (false);
			} /*else if (!mySpawnPoint.isPlaced) {
				transform.position = levelSpawn.position;
				transform.localScale = new Vector3 (1, 1, 1);
				myMove.speed = 100;
				myMove.jumpDivider = 5;
			}*/
		}
	}
}
