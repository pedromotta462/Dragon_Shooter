using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour {
	public static int lvl; 
	// Use this for initialization
	void Start () {
		lvl += 1;
	    PlayerPrefs.SetInt ("Level",lvl);
		PlayerPrefs.Save ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
