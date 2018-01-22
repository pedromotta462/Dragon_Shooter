using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TrocadeCena : MonoBehaviour {
	bool suva;
	void Start(){
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;

	}
	void Update () {
		
		//troca de cena genérica 
	}
	public void troca(string x){
		SceneManager.LoadScene (x);
		Time.timeScale = 1;

	}
}
