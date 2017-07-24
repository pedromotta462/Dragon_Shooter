using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EarthLife : MonoBehaviour {
	
	public float sl;
	public int vidas = 125;
	public GameObject text;
	public ParticleSystem pp;
	public RectTransform terra, escudo;

	void Start(){
		text.SetActive (false);
		StartCoroutine (msn ());
		pp = GetComponent<ParticleSystem> ();
		sl = 125;
	}
	void Update()
	{
		escudo.sizeDelta = new Vector2 (sl, 30f);

	}
	void OnCollisionEnter (Collision coll){
		if (coll.gameObject.tag=="Obstaculo") {
			sl -= 40;
			Destroy (coll.gameObject);
			if (sl<=0) {
				perdervida (coll.gameObject, 125);
			}
			    text.SetActive (true);
		}
			if (coll.gameObject.tag == "Inimigo") {
			sl -= 40;	
			if (sl<=0) {
				perdervida (coll.gameObject,125);
			}
				text.SetActive (true);
			Destroy (coll.gameObject);
			}
		if (coll.gameObject.tag == "ShotEM") {
			sl -= 21;
			if (sl<=0) {
				perdervida (coll.gameObject,21);
			}
			text.SetActive (true);
			Destroy (coll.gameObject);
		}
			
			if (coll.gameObject.tag == "Boss") {
				perdervida (coll.gameObject,125);
				text.SetActive (true);
		}

		if (coll.gameObject.tag=="Shot") {
			sl -= 21;
			Destroy (coll.gameObject);
			if (sl<=0) {
				perdervida (coll.gameObject, 21);
			}
				text.SetActive (true);
			Debug.Log ("vida: " + vidas + "dano: " + sl);

		}
}
	public void perdervida(GameObject g, int dano){
		vidas -=  dano; 
		Debug.Log ("vida: " + vidas);
		Destroy (g);
		terra.sizeDelta = new Vector2 (vidas, 30f);
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
