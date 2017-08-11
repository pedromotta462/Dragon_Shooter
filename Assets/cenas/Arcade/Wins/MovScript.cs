using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovScript : MonoBehaviour {

	public List<MovieTexture> movie;
	private MovieTexture mov;
	public RawImage screen;
	public AudioSource audioS;

	// Use this for initialization
	void Start () {
	/*	screen.texture = movie;
		audioS.clip = movie.audioClip;
		movie.Play ();
		audioS.Play ();
*/
		switch (EscolhaPL.scene) {
		case "Mercurio":
			screen.texture = movie [1];
			audioS.clip = movie [1].audioClip;
			mov = movie [1];
			mov.Play ();
			audioS.Play ();
			break;
		case "Venus":
			screen.texture = movie [3];
			audioS.clip = movie [3].audioClip;
			mov = movie [3];
			mov.Play ();
			audioS.Play ();
			break;

		case "Terra":
			screen.texture = movie [4];
			audioS.clip = movie [4].audioClip;
			mov = movie [4];
			mov.Play ();
			audioS.Play ();
			break;

		case "Marte":
			screen.texture = movie [2];
			audioS.clip = movie [2].audioClip;
			mov = movie [2];
			mov.Play ();
			audioS.Play ();
			break;

		case "Júpiter":
			screen.texture = movie [8];
			audioS.clip = movie [8].audioClip;
			mov = movie [8];
			mov.Play ();
			audioS.Play ();
			break;

		case "Saturno":
			screen.texture = movie [7];
			audioS.clip = movie [7].audioClip;
			mov = movie [7];
			mov.Play ();
			audioS.Play ();
			break;

		case "Urano":
			screen.texture = movie [6];
			audioS.clip = movie [6].audioClip;
			mov = movie [6];
			mov.Play ();
			audioS.Play ();
			break;

		case "Netuno":
			screen.texture = movie [5];
			audioS.clip = movie [5].audioClip;
			mov = movie [5];
			mov.Play ();
			audioS.Play ();
			break;

		case "Plutão":
			screen.texture = movie [0];
			audioS.clip = movie [0].audioClip;
			mov = movie [0];
			mov.Play ();
			audioS.Play ();
			break;
		
		}
	}

	void Update() {
		if (!mov.isPlaying) {
			
		}
	}


}
