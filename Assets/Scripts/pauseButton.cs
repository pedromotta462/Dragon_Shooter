using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class pauseButton : MonoBehaviour {
	
	public GameObject painel, interfac,folego;
	public FirstPersonController desative;


	// Use this for initialization
	void Start () {
		folego.SetActive (true);
		interfac.SetActive (true);
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
	{       folego.SetActive (false);
		    painel.SetActive (true);
		    interfac.SetActive (false);
			desative.enabled = false;
			Time.timeScale = 0;
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;

	
			

	}
	public void close(){
		folego.SetActive (true);
		desative.enabled = true;
		interfac.SetActive (true);
		painel.SetActive (false);
		Time.timeScale = 1;
	}
}
