using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class pauseButton : MonoBehaviour {
	
	public GameObject painel;
	public FirstPersonController desative;


	// Use this for initialization
	void Start () {
		
		Time.timeScale = 1;
        painel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetKeyDown("escape")) {
		//	pause (true);
		//}
	}

	public void pause()
	{ 
		painel.SetActive (true);

			desative.enabled = false;
			Time.timeScale = 0;
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;

	
			

	}
	public void close(){
		desative.enabled = true;
		painel.SetActive (false);
		Time.timeScale = 1;
	}
}
