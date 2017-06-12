using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocadeCena : MonoBehaviour {
	void Start(){
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		PlayerPrefs.SetInt ("Arcade", 0);
	}

	void Update () {
		
	}
	public void troca(string x){
		PlayerPrefs.SetInt ("Arcade", 1);
		SceneManager.LoadScene (x);

	}
}
