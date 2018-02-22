using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	Spawn mySpawnPoint;
	Transform levelSpawn;

	// Use this for initialization
	void Start () {
		mySpawnPoint = GetComponent<Spawn> ();
		levelSpawn = GameObject.Find ("Spawn").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire2")) {
			if (mySpawnPoint.isPlaced) {
				transform.position = mySpawnPoint.spawnPoint;
				mySpawnPoint.isPlaced = false;
				mySpawnPoint.clone.SetActive (false);
			} else if (!mySpawnPoint.isPlaced) {
				transform.position = levelSpawn.position;
			}
		}
	}
}
