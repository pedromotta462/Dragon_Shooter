using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EscolhaCenaSurva : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
		PlayerPrefs.SetInt ("Survival", 0);

	}

	public void troca(int x){
		PlayerPrefs.SetInt ("Survival", 1);
		SceneManager.LoadScene (x);
	} 
	// Update is called once per frame
	void Update () {
		
	}
}
