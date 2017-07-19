using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EarthLife : MonoBehaviour {
	public Slider sl;
	public Image image;
	public Sprite[] spr;
	public int vidas = 6;
	public GameObject text;
	public ParticleSystem pp;
	float i = 1;
	void Start(){
		text.SetActive (false);
		StartCoroutine (msn ());
		pp = GetComponent<ParticleSystem> ();

	}
	void OnCollisionEnter (Collision coll){
		if (coll.gameObject.tag=="Obstaculo") {
			
			sl.value = -0.4f;
			if (sl.value<=0) {
				perdervida (coll.gameObject, 3);
			}
			    text.SetActive (true);
		}
			if (coll.gameObject.tag == "Inimigo") {
			sl.value -= 0.4f;	
			if (sl.value<=0) {
				perdervida (coll.gameObject,6);
			}
				text.SetActive (true);
			Destroy (coll.gameObject);
			}
		if (coll.gameObject.tag == "ShotEM") {
			sl.value -= 0.2f;
			if (sl.value<=0) {
				perdervida (coll.gameObject,1);
			}
			text.SetActive (true);
			Destroy (coll.gameObject);
		}
			
			if (coll.gameObject.tag == "Boss") {
				perdervida (coll.gameObject,6);
				text.SetActive (true);
		}

		if (coll.gameObject.tag=="Shot") {
			sl.value -= 0.4f;
			Destroy (coll.gameObject);
			if (sl.value<=0) {
				perdervida (coll.gameObject, 1);
			}

			text.SetActive (true);
		}
		}

	public void perdervida(GameObject g, int dano){
		vidas = vidas - dano; 
		anima ();
		Destroy (g);

	}
		void anima(){
			switch(vidas){
		case 5:
			image.sprite = spr [0];
			break;
		case 4:
			image.sprite = spr [1];
			break;
		case 3:
			image.sprite = spr [2];
			break;
		case 2:
			image.sprite = spr [3];
			break;
		case 1:
			image.sprite = spr [4];
			break;
		default:
			break;
			}
		if (vidas <= 0) {
			Cursor.lockState = CursorLockMode.None;
			SceneManager.LoadScene (7);
		}
		}

	
	IEnumerator msn(){
		while (true) {
			yield return new WaitForSeconds (3);
			text.SetActive (false);
		}
	



	}


}
