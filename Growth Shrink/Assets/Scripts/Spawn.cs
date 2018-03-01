﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	public GameObject spawnPointPrefab;
	public Vector3 spawnPoint1;
	public Vector3 spawnPoint2;
	public bool firstPlaced;
	public bool canPlaceSecond;
	public bool secondPlaced;
	public GameObject clone1;
	public GameObject clone2;
	public float speed1;
	public float speed2;
	public int jump1;
	public int jump2;

	Grow myGrow;
	Move myMove;

	// Use this for initialization
	void Start ()
	{
		firstPlaced = false;
		myMove = GetComponent<Move> ();
		myGrow = GetComponent<Grow> ();
		canPlaceSecond = false;
		secondPlaced = false;
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		if (Input.GetAxis ("Drop") == 1) {
			if (transform.localScale.x > 1) {
				if (!firstPlaced) {
					spawnPoint1 = new Vector3 (transform.position.x, transform.position.y, transform.position.z - 1);
					Instantiate (spawnPointPrefab, spawnPoint1, gameObject.transform.rotation);
					clone1 = GameObject.Find ("Spawn Point(Clone)");
					clone1.name = "First";
					clone1.transform.localScale = gameObject.transform.localScale;
					speed1 = myMove.speed;
					jump1 = myMove.jumpDivider;
					firstPlaced = true;
					gameObject.transform.localScale -= new Vector3 (myGrow.growthIncrease, myGrow.growthIncrease, 0);
					myMove.speed -= 200;
					myMove.jumpDivider -= 5;
				} else if (canPlaceSecond) {
					spawnPoint2 = new Vector3 (transform.position.x, transform.position.y, transform.position.z - 1);
					Instantiate (spawnPointPrefab, spawnPoint2, gameObject.transform.rotation);
					clone2 = GameObject.Find ("Spawn Point(Clone)");
					clone2.name = "Second";
					clone2.transform.localScale = gameObject.transform.localScale;
					speed2 = myMove.speed;
					jump2 = myMove.jumpDivider;
					secondPlaced = true;
					gameObject.transform.localScale -= new Vector3 (myGrow.growthIncrease, myGrow.growthIncrease, 0);
					myMove.speed -= 200;
					myMove.jumpDivider -= 5;
				}
			}
		} else {
			if (firstPlaced) {
				canPlaceSecond = true;
			} else if (!firstPlaced) {
				canPlaceSecond = false;
			}
		}
	}
}

