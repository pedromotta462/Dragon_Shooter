using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovScript : MonoBehaviour {

	public List <MovieTexture> filme;
	private MovieTexture mov;
	public RawImage screen;
	public AudioSource audioS;
	public GameObject botoes;
	// Use this for initialization
	void Start () {
		botoes.SetActive (false);
	/*	screen.texture = movie;
		audioS.clip = movie.audioClip;
		movie.Play ();
		audioS.Play ();
*/
		switch (EscolhaPL.scene) {
		case "Mercurio":
			screen.texture = filme [1];
			audioS.clip = filme [1].audioClip;
			mov = filme [1];
			mov.Play ();
			audioS.Play ();
			break;
		case "Venus":
			screen.texture = filme [3];
			audioS.clip = filme [3].audioClip;
			mov = filme [3];
			mov.Play ();
			audioS.Play ();
			break;

		case "Terra":
			screen.texture = filme [4];
			audioS.clip = filme [4].audioClip;
			mov = filme [4];
			mov.Play ();
			audioS.Play ();
			break;

		case "Marte":
			screen.texture = filme [2];
			audioS.clip = filme [2].audioClip;
			mov = filme [2];
			mov.Play ();
			audioS.Play ();
			break;

		case "Júpiter":
			screen.texture = filme [8];
			audioS.clip = filme [8].audioClip;
			mov = filme [8];
			mov.Play ();
			audioS.Play ();
			break;

		case "Saturno":
			screen.texture = filme [7];
			audioS.clip = filme [7].audioClip;
			mov = filme [7];
			mov.Play ();
			audioS.Play ();
			break;

		case "Urano":
			screen.texture = filme [6];
			audioS.clip = filme [6].audioClip;
			mov = filme [6];
			mov.Play ();
			audioS.Play ();
			break;

		case "Netuno":
			screen.texture = filme [5];
			audioS.clip = filme [5].audioClip;
			mov = filme [5];
			mov.Play ();
			audioS.Play ();
			break;

		case "Plutão":
			screen.texture = filme [0];
			audioS.clip = filme [0].audioClip;
			mov = filme [0];
			mov.Play ();
			audioS.Play ();
			break;
		
		}
	}

	void Update() {
		if (!mov.isPlaying) {
			botoes.SetActive (true);
		}
	}


}
