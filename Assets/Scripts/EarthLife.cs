using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EarthLife : MonoBehaviour {
	
	public float sl,dPlayer,dInimigo,dBoss,dObs,vidas;
	public GameObject text;
	public ParticleSystem particle;
	public RectTransform terra, escudo;

	void Start(){
		//mensagem de aviso quando o planeta for atacado e a vida do escudo e o nome da fase que encontra 
		text.SetActive (false);
		StartCoroutine (msn ());
		particle = GetComponent<ParticleSystem> ();
		sl = 125;
		EscolhaPL.scene = SceneManager.GetActiveScene ().name;
	}
	void Update()
	{
		//barra de vida do escudo 
		escudo.sizeDelta = new Vector2 (sl, 30f);

	}
	void OnCollisionEnter (Collision coll){
		//dano que cada objeto e personagens causam a terra 
		if (coll.gameObject.tag=="Obstaculo") {
			sl -= dObs;
			Destroy (coll.gameObject);
			if (sl<=0) {
				perdervida (coll.gameObject, 125);
			}
			    text.SetActive (true);
		}
			if (coll.gameObject.tag == "Inimigo") {
			sl -= dInimigo;	
			if (sl<=0) {
				perdervida (coll.gameObject,125);
			}
				text.SetActive (true);
			Destroy (coll.gameObject);
			}
		if (coll.gameObject.tag == "ShotEM") {
			sl -= dInimigo;
			if (sl<=0) {
				perdervida (coll.gameObject,dInimigo);
			}
			text.SetActive (true);
			Destroy (coll.gameObject);
		}
			
			if (coll.gameObject.tag == "Boss") {
				perdervida (coll.gameObject,125);
				text.SetActive (true);
		}

		if (coll.gameObject.tag=="Shot") {
			sl -= dPlayer;
			Destroy (coll.gameObject);
			if (sl<=0) {
				perdervida (coll.gameObject, dPlayer);
			}
				text.SetActive (true);


		}
}
	//vida da terra até ser destruida e dar game over
	public void perdervida(GameObject g, float dano){
		vidas -=  dano; 
		Destroy (g);
		terra.sizeDelta = new Vector2 (vidas, 30f);
		if (vidas <= 0) {
			Cursor.lockState = CursorLockMode.None;
			if (PlayerPrefs.GetInt("Survival")==1) {
				SceneManager.LoadScene ("Over");		
			} else 	{
				SceneManager.LoadScene ("GameOver");
			}			
		}

	}
	//mensagem que a terra está sobre ataque 
	IEnumerator msn(){
		while (true) {
			yield return new WaitForSeconds (3);
			text.SetActive (false);
		}
	}

}
