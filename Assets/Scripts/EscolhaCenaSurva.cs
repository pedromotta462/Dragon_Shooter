using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EscolhaCenaSurva : MonoBehaviour {
	// Use this for initialization
	public GameObject painel;
	void Start () {
		painel.SetActive (false);
		PlayerPrefs.SetInt ("Survival", 0);

	}
	public void back(){
		PlayerPrefs.SetInt ("Survival", 0);
		painel.SetActive (false);

	}
	public void troca(string x){
		PlayerPrefs.SetInt ("Survival", 1);
		painel.SetActive (true);

	} 
	// Update is called once per frame
	void Update () {
		
	}
}
