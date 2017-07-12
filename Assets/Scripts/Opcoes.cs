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
	
	// Update is called once per frame
	void Update () {
		
	}
	public void click(){
		botoes.SetActive (false);
		somfundo.SetActive (true);

	}
	public void back(){
		botoes.SetActive (true);
		somfundo.SetActive (false);

	}
}
