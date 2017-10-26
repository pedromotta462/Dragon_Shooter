using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EscolhaCenaSurva : MonoBehaviour {
	// Use this for initialization
	public GameObject df;
	void Start () {
		df.SetActive (false);
		PlayerPrefs.SetInt ("Survival", 0);

	}
	public void back(){
		PlayerPrefs.SetInt ("Survival", 0);
		df.SetActive (false);

	}
	public void troca(string x){
		PlayerPrefs.SetInt ("Survival", 1);
		df.SetActive (true);

	} 
	// Update is called once per frame
	void Update () {
		
	}
}
