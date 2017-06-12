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
	int soma=5;
	int gambiarra;
	bool test;
	void Start(){
		test = false;
		shiel = FindObjectOfType<EarthLife> ();



	
	}
	// Update is called once per frame
void Update ()
	{


		}
	void OnTriggerEnter(Collider coll){
		if (coll.gameObject.tag=="NaoSai") {
			aviso.SetActive (false);
			test = false;
			soma = 5;
		}
	}
	void OnTriggerExit(Collider coll){
		if (coll.gameObject.tag=="NaoSai") {
			aviso.SetActive (true);
			test = true;
			gambiarra += 1;
			if (gambiarra==2) {
				soma -= 1;
				txt.text = "Você está se distanciando do seu objetivo, retorne em até: " + soma + "s";
				gambiarra = 0;
			}


		}
	}

	void OnCollisionEnter(Collision coll ){
		if (coll.gameObject.tag=="Obstaculo") {
			sl.value -= 0.5f;
		}
		if (coll.gameObject.tag=="shield") {
			shield.value += 0.2f;
			Destroy (coll.gameObject);
		}
		if (coll.gameObject.tag=="Inimigo") {
			sl.value -= 0.2f;
			Destroy (coll.gameObject);
		
		}
		if (coll.gameObject.tag=="ShotEM") {
			sl.value -= 0.2f;
			Destroy (coll.gameObject);

		}
		if (coll.gameObject.tag=="Shield") {
			Destroy (coll.gameObject);
			shiel.sl.value += 0.5f;
		}
		if (sl.value==0) {
			Cursor.lockState = CursorLockMode.None;
			SceneManager.LoadScene (7);

		}

	}


}

