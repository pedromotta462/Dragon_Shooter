using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PM : MonoBehaviour {
	
	public GameObject aviso,escudo,AvisoEscudo;
	public float sl;
	EarthLife shiel;
	public Text txt;
	int soma = 11;
	bool controle,mensagem;
	public Score score;
	public float startYPosition,dInimigo,dBoss;
	public RectTransform pl;
	public float vInimigo,vShotIni,cadenciaShot,vidaBoss;
	void Start(){
		AvisoEscudo.SetActive (false);
		startYPosition = transform.position.y;
		shiel = FindObjectOfType<EarthLife> ();
		controle = false;
		StartCoroutine (protect ());

}
	void Update(){
		pl.sizeDelta = new Vector2 (sl, 30f);
	if (shiel.sl <= 0) {
			if (mensagem) {
				AvisoEscudo.SetActive (true);
				escudo.SetActive (false);
				mensagem = false;
			}
		
	} else {
		escudo.SetActive (true);
			mensagem = true;
		}
		if (sl<=0) {
			Cursor.lockState = CursorLockMode.None;
			if (PlayerPrefs.GetInt("Suvival")==1) {
				SceneManager.LoadScene ("Over");		
			} else {
				SceneManager.LoadScene ("GameOver");
			}			
		
		}			
	}
	void OnCollisionEnter(Collision coll){
		if (coll.gameObject.tag=="Bonus") {
			Destroy	(coll.gameObject);
			sl -= 125;
		}
		if (coll.gameObject.tag=="Boss") {
			Destroy (coll.gameObject);
			sl -= 80;
		}
		if (coll.gameObject.tag=="Obstaculo") {
			sl -= 125;
			Destroy (coll.gameObject);
		}

		if (coll.gameObject.tag=="Inimigo") {
			sl -= dInimigo;
			Debug.Log ("ueeee");
			Destroy (coll.gameObject);

		}

		if (coll.gameObject.tag=="Shield") {
			Destroy (coll.gameObject);
			if (shiel.sl<=125) {
				shiel.sl += 80;
				Destroy (coll.gameObject);
			}
		}
	}

	void OnTriggerEnter(Collider coll){
		controle = false;
		if (coll.gameObject.tag=="NaoSai") {
			aviso.SetActive (false);
			soma = 11;
		}
		if (coll.gameObject.tag=="ShotEM") {
			sl -= dInimigo;
			Destroy (coll.gameObject);
		}
	}
	void OnTriggerExit(Collider coll){
		controle = true;
		if (coll.gameObject.tag == "NaoSai") {
			aviso.SetActive (true);
			StartCoroutine (cont ());
		}
	}




	IEnumerator cont(){
		while (controle) {
			yield return new WaitForSeconds (1);
			soma-= 1;
			txt.text = "you are distancing yourself from your objective,retun in: " + soma + " " + "seconds";
		if (soma <= 0f) {
				if (PlayerPrefs.GetInt("Suvival")==1) {
					SceneManager.LoadScene ("Over");		
				} else {
					SceneManager.LoadScene ("GameOver");
				}			
			}
		}
	}
	IEnumerator protect(){
		while (true) {
			yield return new WaitForSeconds (3);
			AvisoEscudo.SetActive (false);
		}
			
	}

	void LateUpdate() {
		Vector3 v = transform.position;
		v.y = startYPosition;
		transform.position = v;
	}
}

