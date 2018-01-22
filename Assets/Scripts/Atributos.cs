using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
public class Atributos : MonoBehaviour {
	public Text txt,Pfolego,Pspeed,Psorte,Prange;
	int pp;
	// Use this for initialization
	void Start () {
		//Numero de pontos de cada atributo 
		Pfolego.text = "" + PlayerPrefs.GetInt("Breath");
		Psorte.text = "" + PlayerPrefs.GetInt("Lucky");;
		Prange.text = "" + 0;
		Pspeed.text = "" + PlayerPrefs.GetInt("Velocidade");
	}
	
	// Update is called once per frame
	void Update () {
		//quantidade de pontos a ser distribuidos 
		txt.text="YOU HAVE "+PlayerPrefs.GetInt("Up")+ " point(s) to destribute";
	}
	//aumentos de cada classe dos atributos usando valores já guardados 
	public void speed(){
		if (PlayerPrefs.GetInt ("Up") >= 1) {
			PlayerPrefs.SetInt ("Velocidade", PlayerPrefs.GetInt ("Velocidade") + 1);
			Pspeed.text = "" + PlayerPrefs.GetInt("Velocidade");
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
			PlayerPrefs.SetInt ("Breath", PlayerPrefs.GetInt ("Breath") + 1);
			Pfolego.text = "" + PlayerPrefs.GetInt("Breath");
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
			PlayerPrefs.SetInt("Lucky", PlayerPrefs.GetInt("Lucky") + 1);
			Psorte.text = "" + PlayerPrefs.GetInt("Lucky");;
			if (PlayerPrefs.GetInt ("Sorte") >= 1) {
				PlayerPrefs.SetInt ("Sorte", PlayerPrefs.GetInt ("Sorte") + 1);
			} else {
				PlayerPrefs.SetInt ("Sorte", 1);
			}
			PlayerPrefs.SetInt ("Up", PlayerPrefs.GetInt ("Up") - 1);
		}

	}


	}

