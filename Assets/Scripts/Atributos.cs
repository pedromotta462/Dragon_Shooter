using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class Atributos : MonoBehaviour {
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void speed(){
		if (PlayerPrefs.GetInt("Up")>=1) {
			FirstPersonController.bonusSpedd += 5;
			} else {
			Debug.Log ("funfou");
		}

	}
	public void folego(){
		if (PlayerPrefs.GetInt("Up")>=1) {
			Folego.folego -= 0.05f;
		}

	}
	public void sorte(){
		if (PlayerPrefs.GetInt("Up")>=1) {
			SpawOBS.sorte -= 1;
		}

	}
	public void rotação(){
		if (PlayerPrefs.GetInt("Up")>=1) {
			FirstPersonController.rotacao += 1;
		}

	}
}
