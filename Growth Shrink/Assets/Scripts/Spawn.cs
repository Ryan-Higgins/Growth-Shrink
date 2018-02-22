using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	public GameObject spawnPointPrefab;
	public Vector3 spawnPoint;
	public bool isPlaced;
	public GameObject clone;
	Grow myGrow;

	// Use this for initialization
	void Start ()
	{
		isPlaced = false;
		myGrow = GetComponent<Grow> ();
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown ("Fire1")) {
			if (!isPlaced) {
				if (transform.localScale.x > 1) {
					spawnPoint = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
					Instantiate (spawnPointPrefab, spawnPoint, gameObject.transform.rotation);
					isPlaced = true;
					gameObject.transform.localScale -= new Vector3 (myGrow.growthIncrease, myGrow.growthIncrease, 0);
					clone = GameObject.Find ("Spawn Point(Clone)");
				}
			}
		}
	}
}
