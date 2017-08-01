using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Reset : MonoBehaviour {
	public GameObject txt;
	// Use this for initialization
	void Start () {
		txt.SetActive (false);
		StartCoroutine (gg ());
	}
	
	public void click(){
		PlayerPrefs.SetInt ("Level", 0);
		txt.SetActive (true);
	}
	IEnumerator gg(){
		while (true) {
			yield return new WaitForSeconds (3);
			txt.SetActive (false);
		}
	}
}
