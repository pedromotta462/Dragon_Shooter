using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PM : MonoBehaviour {
	
	public GameObject aviso;
	public Slider sl,shield;
	EarthLife shiel;
	public Text txt;
	int soma=11;
	int gambiarra;
	bool controle;

	void Start(){
		
		shiel = FindObjectOfType<EarthLife> ();
		controle = false;


	
	}
	// Update is called once per frame
void Update ()
	{


		}

	void OnTriggerEnter(Collider coll){
		controle = false;
		if (coll.gameObject.tag=="NaoSai") {
			aviso.SetActive (false);
			soma = 11;
		}
	}

	void OnTriggerExit(Collider coll){
		
		controle = true;
		if (coll.gameObject.tag == "NaoSai" && controle) {
			controle = false;
			StartCoroutine (cont ());
			aviso.SetActive (true);
		}
	}

	void OnControllerColliderHit(ControllerColliderHit coll){
		if (coll.gameObject.tag=="Obstaculo") {
			sl.value -= 0.5f;
			Debug.Log ("HI1");

		}
		if (coll.gameObject.tag=="shield") {
			shield.value += 0.2f;
			Debug.Log ("HI2");

			Destroy (coll.gameObject);
		}
		if (coll.gameObject.tag=="Inimigo") {
			sl.value -= 0.2f;
			Debug.Log ("HI3");
			Destroy (coll.gameObject);

		}
		if (coll.gameObject.tag=="ShotEM") {
			sl.value -= 0.2f;
			Destroy (coll.gameObject);
			Debug.Log ("HI4");


		}
		if (coll.gameObject.tag=="Shield") {
			Destroy (coll.gameObject);
			shiel.sl.value += 0.5f;
			Debug.Log ("HI5");

		}
		if (coll.gameObject.tag=="NaoSai") {
			controle = false;
			aviso.SetActive (false);
			soma = 11;
		} else {
			controle = true;
			aviso.SetActive (false);
		}
		if (sl.value==0) {
			Cursor.lockState = CursorLockMode.None;
			SceneManager.LoadScene (7);

		}
	}


	IEnumerator cont(){
		int time = 10;
		while (controle) {
			yield return new WaitForSeconds (1f);
			time--;
			soma-= 1;
			txt.text = "Você está se distanciando do seu objetivo, retorne em até: " + soma + "s";
			if (time <= 0f) {
				//gameOver
			}
		}
	}

}

