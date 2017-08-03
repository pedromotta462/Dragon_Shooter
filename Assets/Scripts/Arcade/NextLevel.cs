using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {
	public static int lvl; 
	public static int up;

	// Use this for initialization
	void Start () {
		up++;
		switch (SceneManager.GetActiveScene ().name) {
		case"Twin":
			PlayerPrefs.SetInt ("Netuno", 1);
			break;
		case"Mwin":
			PlayerPrefs.SetInt ("Marte", 1);
			break;
		
		case"Swin":
			PlayerPrefs.SetInt ("Jupiter", 1);
			break;

		case"Marswin":
			PlayerPrefs.SetInt ("Venus", 1);
			break;

		case"Vwin":
			PlayerPrefs.SetInt ("Terra", 1);
			break;

		case"Uwin":
			PlayerPrefs.SetInt ("Saturno", 1);
			break;

		case"Nwin":
			PlayerPrefs.SetInt ("Urano", 1);
			break;

		case"Pwin":
			PlayerPrefs.SetInt ("Mercurio", 1);
			break;
		}

		PlayerPrefs.SetInt ("Up", up);
		PlayerPrefs.SetInt ("Level",lvl);
		PlayerPrefs.Save ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
