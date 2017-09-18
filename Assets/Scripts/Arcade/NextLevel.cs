using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {
	public static int lvl; 
	public static int up;

	// Use this for initialization
	void Start () {

		switch (SceneManager.GetActiveScene ().name) {
		case"Jwin":
			if (PlayerPrefs.GetInt ("Final") == 0) {
				up++;
			}
			PlayerPrefs.SetInt ("Final", 1);
			break;
		case"Twin":
			if (PlayerPrefs.GetInt("Netuno")==0) {
				up++;
			}
			PlayerPrefs.SetInt ("Netuno", 1);
			break;
		case"Mwin":
			if (PlayerPrefs.GetInt("Marte")==0) {
				up++;
			}
			PlayerPrefs.SetInt ("Marte", 1);
			break;
		
		case"Swin":
			if (PlayerPrefs.GetInt("Jupiter")==0) {
				up++;
			}
			PlayerPrefs.SetInt ("Jupiter", 1);
			break;

		case"Marswin":
			if (PlayerPrefs.GetInt("Venus")==0) {
				up++;
			}
			PlayerPrefs.SetInt ("Venus", 1);
			break;

		case"Vwin":
			if (PlayerPrefs.GetInt("Terra")==0) {
				up++;
			}
			PlayerPrefs.SetInt ("Terra", 1);
			break;

		case"Uwin":
			if (PlayerPrefs.GetInt("Saturno")==0) {
				up++;
			}
			PlayerPrefs.SetInt ("Saturno", 1);
			break;

		case"Nwin":
			if (PlayerPrefs.GetInt("Urano")==0) {
				up++;
			}
			PlayerPrefs.SetInt ("Urano", 1);
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
