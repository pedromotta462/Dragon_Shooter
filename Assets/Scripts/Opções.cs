using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opções : MonoBehaviour {
	public GameObject botoes,opçoes;
	// Use this for initialization
	void Start () {
		botoes.SetActive (true);
		opçoes.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void click(){
		botoes.SetActive (false);
		opçoes.SetActive (true);
	}
	public void back(){
		botoes.SetActive (true);
		opçoes.SetActive (false);
	}
}
