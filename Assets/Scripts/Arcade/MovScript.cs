using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovScript : MonoBehaviour {

	public List <Handheld> filme;
	private Handheld mov;
	public RawImage screen;
	public AudioSource audioS;
	public GameObject botoes;
	// Use this for initialization
	void Start () {
		botoes.SetActive (false);
		StartCoroutine (video ());
		//Handheld.PlayFullScreenMovie ("Video.mp4",Color.black,FullScreenMovieControlMode.Hidden,FullScreenMovieScalingMode.Fill);
	/*	screen.texture = movie;
		audioS.clip = movie.audioClip;
		movie.Play ();
		audioS.Play ();
*/
//		switch (EscolhaPL.scene) {
//		case "Mercurio":
//
//		
//			break;
//		case "Venus":
//
//			break;
//
//		case "Terra":
//			
//			break;
//
//		case "Marte":
//
//			break;
//
//		case "Júpiter":
//
//			break;
//
//		case "Saturno":
//	
//			break;
//
//		case "Urano":
//
//			break;
//
//		case "Netuno":
//	
//			break;
//
//		case "Plutão":
//			
//			break;
//		
//		}
		//Handheld.PlayFullScreenMovie (Application.streamingAssetsPath +	"/" + variavelString + ".mp4");
	}

	void Update() {
		if (Handheld.PlayFullScreenMovie ("Video.mp4",Color.black,FullScreenMovieControlMode.Hidden) == null) {
			botoes.SetActive (true);
		}
	}
	IEnumerator video(){
		Handheld.PlayFullScreenMovie ("Video.mp4", Color.black, FullScreenMovieControlMode.Hidden, FullScreenMovieScalingMode.Fill);
		yield return new WaitForEndOfFrame ();
		botoes.SetActive (true);
	}


}
