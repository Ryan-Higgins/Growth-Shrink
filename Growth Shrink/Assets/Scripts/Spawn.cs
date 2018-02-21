using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	public GameObject spawnPointPrefab;
	Vector3 spawnPoint;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
		if (Input.GetButtonDown ("Fire1")) {
			spawnPoint = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
			Instantiate (spawnPointPrefab,spawnPoint,gameObject.transform.rotation);
		}
	}
}
