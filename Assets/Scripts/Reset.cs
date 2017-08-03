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
		PlayerPrefs.SetInt ("Netuno", 0);
		PlayerPrefs.SetInt ("Marte", 0);
		PlayerPrefs.SetInt ("Jupiter", 0);
		PlayerPrefs.SetInt ("Venus", 0);
		PlayerPrefs.SetInt ("Terra", 0);
		PlayerPrefs.SetInt ("Saturno", 0);
		PlayerPrefs.SetInt ("Urano", 0);
		PlayerPrefs.SetInt ("Mercurio", 0);
		txt.SetActive (true);
	}
	IEnumerator gg(){
		while (true) {
			yield return new WaitForSeconds (3);
			txt.SetActive (false);
		}
	}
}
