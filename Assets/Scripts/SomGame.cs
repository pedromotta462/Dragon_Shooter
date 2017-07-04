using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SomGame : MonoBehaviour {
	public AudioSource som; 
	public Slider sl;
	// Use this for initialization
	void Start () {
		som= GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		AudioListener.volume = sl.value;
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
