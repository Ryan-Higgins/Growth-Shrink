using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrumblingPlatform : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (Crumble());
	}

	IEnumerator Crumble() {
		yield return new WaitForSeconds(1);
		gameObject.SetActive (false);
	}
}
