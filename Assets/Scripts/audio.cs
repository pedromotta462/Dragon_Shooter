using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class audio : MonoBehaviour {
	public AudioSource som; 
	public GameObject canva;

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad (canva);
		som= GetComponent<AudioSource> ();
		if (SceneManager.GetActiveScene ().name == "pregame") {
			Score.pontos = 0;
			SceneManager.LoadScene ("Play");	
		}

	}
	
	// Update is called once per frame
	void Update () {
		
		if (SceneManager.GetActiveScene().name=="Game") {
			Destroy (canva);
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


