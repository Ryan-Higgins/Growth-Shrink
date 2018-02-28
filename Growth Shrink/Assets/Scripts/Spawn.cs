using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	public GameObject spawnPointPrefab;
	public Vector3 spawnPoint1;
	public Vector3 spawnPoint2;
	public bool firstPlaced;
	public GameObject clone1;
	public GameObject clone2;
	Grow myGrow;

	// Use this for initialization
	void Start ()
	{
		firstPlaced = false;
		myGrow = GetComponent<Grow> ();
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		if (Input.GetAxis ("Drop") == 1) {
			if (transform.localScale.x > 1) {
				if (!firstPlaced) {
					spawnPoint1 = new Vector3 (transform.position.x, transform.position.y, transform.position.z - 1);
					Instantiate (spawnPointPrefab, spawnPoint1, gameObject.transform.rotation);
					firstPlaced = true;
					gameObject.transform.localScale -= new Vector3 (myGrow.growthIncrease, myGrow.growthIncrease, 0);
					clone1 = GameObject.Find ("Spawn Point(Clone)");
					clone1.name = "First";
				} else if (firstPlaced) {
					spawnPoint2 = new Vector3 (transform.position.x, transform.position.y, transform.position.z - 1);
					Instantiate (spawnPointPrefab, spawnPoint2, gameObject.transform.rotation);
					gameObject.transform.localScale -= new Vector3 (myGrow.growthIncrease, myGrow.growthIncrease, 0);
					clone2 = GameObject.Find ("Spawn Point(Clone)");
					clone2.name = "Second";
				}
			}
		}
	}
}

