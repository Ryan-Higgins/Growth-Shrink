using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{

	Spawn mySpawnPoint;
	Move myMove;
	bool spawnAtTwo;

	// Use this for initialization
	void Start ()
	{
		mySpawnPoint = GetComponent<Spawn> ();
		myMove = GetComponent<Move> ();
		spawnAtTwo = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetAxis ("Spawn") == 1) {		
			if (mySpawnPoint.clone1.activeInHierarchy && mySpawnPoint.oldest == 1) {
				if (!spawnAtTwo) {
					//gameObject.transform.position = mySpawnPoint.spawnPoint1;
					gameObject.transform.position = mySpawnPoint.clone1.transform.position;
					gameObject.transform.localScale = mySpawnPoint.clone1.transform.localScale;
					myMove.speed = mySpawnPoint.speed1;
					myMove.jumpDivider = mySpawnPoint.jump1;
					mySpawnPoint.firstPlaced = false;	
					mySpawnPoint.clone1.SetActive (false);
					if (mySpawnPoint.clone2 != null) {
						mySpawnPoint.oldest = 2;
					} else {
						mySpawnPoint.oldest = 0;
					}
				}
			} else if (mySpawnPoint.clone2.activeInHierarchy && mySpawnPoint.oldest == 2) {
				if (spawnAtTwo) {
					//gameObject.transform.position = mySpawnPoint.spawnPoint2;
					gameObject.transform.position = mySpawnPoint.clone2.transform.position;
					gameObject.transform.localScale = mySpawnPoint.clone2.transform.localScale;
					myMove.speed = mySpawnPoint.speed2;
					myMove.jumpDivider = mySpawnPoint.jump2;
					mySpawnPoint.clone2.SetActive (false);
					if (mySpawnPoint.clone1 != null) {
						mySpawnPoint.oldest = 1;
					} else {
						mySpawnPoint.oldest = 0;
					}
				}
			}
		} else {
			if (mySpawnPoint.clone1.activeInHierarchy && mySpawnPoint.oldest == 1) {
				spawnAtTwo = false;
			} else {
				spawnAtTwo = true;
			}
		}
	}
}
