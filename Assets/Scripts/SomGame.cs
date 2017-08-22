using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SomGame : MonoBehaviour {
	public AudioSource som; 
	public Slider sl;
	// Use this for initialization
	void Start () {
		sl.value = PlayerPrefs.GetFloat ("Slider");
		som= GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefs.GetFloat ("Slider", sl.value);
		AudioListener.volume = sl.value;
		PlayerPrefs.SetFloat ("Slider", sl.value);
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
