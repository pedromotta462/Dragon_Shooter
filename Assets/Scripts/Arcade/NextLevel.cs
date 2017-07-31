using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {
	public static int lvl; 
	// Use this for initialization
	void Start () {
		
		switch (SceneManager.GetActiveScene ().name) {
		case"Twin":
			lvl = 5;
			break;
		case"Mwin":
			lvl = 2;
			break;
		
		case"Swin":
			lvl = 8;
			break;

		case"Marswin":
			lvl = 3;
			break;

		case"Jwin":
			lvl = 9;
			break;

		case"Vwin":
			lvl = 4;
			break;

		case"Uwin":
			lvl = 7;
			break;

		case"Nwin":
			lvl = 6;
			break;

		case"Pwin":
			lvl = 1;
			break;
		}

		PlayerPrefs.SetInt ("Level",lvl);
		PlayerPrefs.Save ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
