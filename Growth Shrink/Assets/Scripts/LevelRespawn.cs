using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRespawn : MonoBehaviour {

	Scene scene;

	// Use this for initialization
	void Start () {
		scene = SceneManager.GetActiveScene ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.R) || Input.GetButtonUp("Cancel")) {
			SceneManager.LoadScene (scene.name);
		}
	}
}
