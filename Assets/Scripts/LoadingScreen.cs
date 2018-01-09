using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadingScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (ff ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator ff(){
		while (true) {
			yield return new WaitForSeconds (3);
			SceneManager.LoadScene ("PLay");
		}
	}
}
