using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class audio : MonoBehaviour {
	public AudioSource som; 
	public GameObject canva;
	public GameObject show;
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
			som.Pause ();
			show.SetActive (false);
		}
		if (SceneManager.GetActiveScene().name=="Arcade") {
			som.Pause ();
			show.SetActive (false);
		}
		if (SceneManager.GetActiveScene().name=="Over") {
			Debug.Log ("pqqq");
			show.SetActive (true);
			som.Play ();
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


