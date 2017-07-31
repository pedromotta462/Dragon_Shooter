using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public void click(){
		PlayerPrefs.SetInt ("Level", 0);
	}

}
