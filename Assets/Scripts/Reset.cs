using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Reset : MonoBehaviour {
	
	public List<GameObject> objs;
	 
	// Use this for initialization
	void Start () {
		objs[0].SetActive (false);
		objs[1].SetActive (false);
		StartCoroutine (gg ());
	}
	
	public void click2(){
		objs[1].SetActive (false);
		objs[2].SetActive (true);
		objs[3].SetActive (true);
		objs[4].SetActive (true);
		PlayerPrefs.SetInt ("Netuno", 0);
		PlayerPrefs.SetInt ("Marte", 0);
		PlayerPrefs.SetInt ("Jupiter", 0);
		PlayerPrefs.SetInt ("Venus", 0);
		PlayerPrefs.SetInt ("Terra", 0);
		PlayerPrefs.SetInt ("Saturno", 0);
		PlayerPrefs.SetInt ("Urano", 0);
		PlayerPrefs.SetInt ("Mercurio", 0);
		PlayerPrefs.SetInt ("Up", 0);
		PlayerPrefs.SetFloat ("Speed", 0);
		objs[0].SetActive (true);
	}
	public void click1()
	{
		objs[1].SetActive (true);
		objs[2].SetActive (false);
		objs[3].SetActive (false);
		objs[4].SetActive (false);

	}
	public void closar()
	{
		objs[1].SetActive (false);
		objs[2].SetActive (true);
		objs[3].SetActive (true);
		objs[4].SetActive (true);

	}

	IEnumerator gg(){
		while (true) {
			yield return new WaitForSeconds (3);
			objs[0].SetActive (false);
		}
	}
}
