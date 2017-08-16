using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
public class Atributos : MonoBehaviour {
	public Text txt;
	// Use this for initialization
	void Start () {
		txt.text="YOU HAVE "+PlayerPrefs.GetInt("Up")+ " point(s) to destribute";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void speed(){
		if (PlayerPrefs.GetInt ("Up") >= 1) {
			PlayerPrefs.SetInt ("Up", PlayerPrefs.GetInt ("Up") - 1);
			if (PlayerPrefs.GetFloat ("Speed") >= 5) {
				PlayerPrefs.SetFloat ("Speed", PlayerPrefs.GetFloat ("Speed") + 5);
			} else {
				PlayerPrefs.SetFloat ("Speed", 5);
			}
			PlayerPrefs.Save ();
		} 

	}
	public void folego(){
		if (PlayerPrefs.GetInt ("Up") >= 1) {
			PlayerPrefs.SetInt ("Up", PlayerPrefs.GetInt ("Up") - 1);
			if (PlayerPrefs.GetFloat ("Folego") >= 0.02f) {
				PlayerPrefs.SetFloat ("Folego", PlayerPrefs.GetFloat ("Folego") + 0.02f);
				PlayerPrefs.SetFloat ("Vfolego", PlayerPrefs.GetFloat ("Vfolego") + 0.01f);
			} else {
				PlayerPrefs.SetFloat ("Folego", 0.02f);
				PlayerPrefs.SetFloat ("Vfolego", 0.01f);
			} 
		}

	}
	public void sorte(){
		if (PlayerPrefs.GetInt ("Up") >= 1) {
			if (PlayerPrefs.GetInt ("Sorte") >= 1) {
				PlayerPrefs.SetInt ("Sorte", PlayerPrefs.GetInt ("Sorte") + 1);
			} else {
				PlayerPrefs.SetInt ("Sorte", 1);
			}
			PlayerPrefs.SetInt ("Up", PlayerPrefs.GetInt ("Up") - 1);
		}

	}


	}

