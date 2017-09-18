using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class audio : MonoBehaviour {
	public AudioSource som; 
	public GameObject canva;
	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad (canva);
		som= GetComponent<AudioSource> ();
		if (SceneManager.GetActiveScene ().name == "pregame") {
			Score.pontos = 0;
		}

	}
	
	// Update is called once per frame
	void Update () {
		AudioListener.volume = PlayerPrefs.GetFloat ("Slider");
		switch (SceneManager.GetActiveScene ().name) {
		case"Over":
			som.UnPause ();
			break;
		case"Game":
			som.Pause ();
			break;
		case"Terra":
			som.Pause ();
			break;
		case"Mercurio":
			som.Pause ();
			break;
		case"Venus":
			som.Pause ();
			break;
		case"Urano":
			som.Pause ();
			break;
		case"Marte":
			som.Pause ();
			break;
		case"Júpiter":
			som.Pause ();
			break;
		case"Plutão":
			som.Pause ();
			break;
		case"Saturno":
			som.Pause ();
			break;
		case"Netuno":
			som.Pause ();
			break;
		case"Twin":
			som.UnPause ();
			break;
		case"PLay":
			som.UnPause ();
			break;
		}





	

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


