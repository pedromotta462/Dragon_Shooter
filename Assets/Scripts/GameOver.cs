using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
	public Text txt;
	bool surva;
	// Use this for initialization
	void Start () {
		surva = PlayerPrefs.GetInt ("Survival") == 1;
		if (surva) {
			txt.text = "Total: " + PlayerPrefs.GetInt ("Score");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
