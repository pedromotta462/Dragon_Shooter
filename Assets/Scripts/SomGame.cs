using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomGame : MonoBehaviour {
	public AudioSource som; 
	// Use this for initialization
	void Start () {
		som= GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void onClick()
	{

		if (som.isPlaying) {
			som.Pause ();
		} else
		{
			som.Play ();
		}
	}
}
