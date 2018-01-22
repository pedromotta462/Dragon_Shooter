using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opcoes : MonoBehaviour {
	public GameObject botoes,somfundo;
	// Use this for initialization
	void Start () {
		botoes.SetActive (true);
		somfundo.SetActive (false);

	}
	//botoes do menu de opções 
	public void click(){
		botoes.SetActive (false);
		somfundo.SetActive (true);

	}
	public void back(){
		botoes.SetActive (true);
		somfundo.SetActive (false);

	}
}
