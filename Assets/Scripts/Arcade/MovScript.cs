using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovScript : MonoBehaviour {

	private Handheld mov;
	string videos;
	public GameObject botoes;
	// Use this for initialization
	void Start () {
		switch (EscolhaPL.scene) {
		case "Mercurio":
			videos = "mercurio";
			break;
		case "Venus":
			videos = "venus";
			break;
		case "Terra":
			videos = "terra";
			break;
		case "Marte":
			videos = "marte";
			break;
		case "Júpiter":
			videos = "jupiter";
			break;
		case "Saturno":
			videos = "saturno";
			break;
		case "Urano":
			videos = "urano";
			break;
		case "Netuno":
			videos = "netuno";
			break;


		}
		botoes.SetActive (false);
		StartCoroutine (video ());
	
	}

	void Update() {

	}
	IEnumerator video(){
		print (videos);
		Handheld.PlayFullScreenMovie (videos+".mp4", Color.black, FullScreenMovieControlMode.Hidden, FullScreenMovieScalingMode.Fill);
		yield return new WaitForEndOfFrame ();
		botoes.SetActive (true);
	}


}
