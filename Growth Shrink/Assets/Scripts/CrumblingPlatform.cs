using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrumblingPlatform : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionStay2D(Collision2D other) {
		if (other.gameObject.tag == "Player") {
			StartCoroutine (Crumble());
		}
	}

	IEnumerator Crumble() {
		yield return new WaitForSeconds(1);
		gameObject.GetComponent<BoxCollider2D>().enabled = false;
		gameObject.GetComponent<MeshRenderer>().enabled = false;
		yield return new WaitForSeconds(3);
		gameObject.GetComponent<BoxCollider2D>().enabled = true;
		gameObject.GetComponent<MeshRenderer>().enabled = true;
	}
}
