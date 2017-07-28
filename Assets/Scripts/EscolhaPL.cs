using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EscolhaPL : MonoBehaviour {
	public static int lvl;
	public Camera cm;
	public float reach=9999f;
	public List<Transform> planetas;
	public Text txt;
	public GameObject painel, button,cadeado;
	public static string scene;

	// Use this for initialization
	void Start () {
		lvl=PlayerPrefs.GetInt ("Level");
		painel.SetActive (false);
		button.SetActive (true);
		cadeado.SetActive (false);
	}

	void Update ()
	{
		RaycastHit hit;
		if (Input.GetMouseButtonDown (0)) {
			//hit.collider.gameObject.GetComponent<Click> ().o = !hit.collider.gameObject.GetComponent<Click> ().o;
			Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit, reach); 
			if (hit.collider) {
				switch (hit.collider.gameObject.tag) {
				case "Mercurio":
					cm.transform.LookAt (planetas [0]);
					Camera.main.fieldOfView = 5;
					txt.text = "Mercury";
					painel.SetActive (true);
					button.SetActive (false);
					if (lvl>=1) {
						cadeado.SetActive (false);
						scene = "Mercurio";
					}else {
						cadeado.SetActive (true);
						scene = "";
					}
						break;
				case "Vênus":
					cm.transform.LookAt (planetas [1]);
					Camera.main.fieldOfView = 10;
					txt.text="Venus";
					painel.SetActive (true);
					button.SetActive (false);
					if (lvl>=3) {
						cadeado.SetActive (false);
						scene = "Venus";
					}else {
						cadeado.SetActive (true);
						scene = "";
					}

					break;

				case "Earth":
					cm.transform.LookAt (planetas [2]);
					Camera.main.fieldOfView = 10;
					txt.text = "Earth";
					painel.SetActive (true);
					button.SetActive (false);
					if (lvl>=4) {
						cadeado.SetActive (false);
						scene = "Terra";
					}else {
						cadeado.SetActive (true);
						scene = " ";
					}

					break;

				case "Marte":
					cm.transform.LookAt (planetas [3]);
					Camera.main.fieldOfView =10;
					txt.text="Mars";
					painel.SetActive (true);
					button.SetActive (false);
					if (lvl>=2) {
						cadeado.SetActive (false);
						scene = "Marte";
					}else {
						cadeado.SetActive (true);
						scene = "";
					}
					break;

				case "Júpiter":
					cm.transform.LookAt (planetas [4]);
					Camera.main.fieldOfView = 20;
					txt.text="Jupiter";
					painel.SetActive (true);
					button.SetActive (false);
					if (lvl>=8) {
						cadeado.SetActive (false);
						scene = "Júpiter";
					}else {
						cadeado.SetActive (true);
						scene = "";
					}
					break;

				case "Saturno":
					cm.transform.LookAt (planetas [5]);
					Camera.main.fieldOfView = 20;
					txt.text="Saturn";
					painel.SetActive (true);
					button.SetActive (false);
					if (lvl>=7) {
						cadeado.SetActive (false);
						scene = "Saturno";
					}else {
						cadeado.SetActive (true);
						scene = "";
					}
					break;

				case "Urano":
					cm.transform.LookAt (planetas [6]);
					Camera.main.fieldOfView = 10;
					txt.text="Uranus";
					painel.SetActive (true);
					if (lvl>=6) {
						cadeado.SetActive (false);
						scene = "Urano";
					}else {
						cadeado.SetActive (true);
						scene = "";
					}
					break;

				case "Netuno":
					cm.transform.LookAt (planetas [7]);					
					Camera.main.fieldOfView = 10;
					txt.text="Neptune";
					painel.SetActive (true);
					button.SetActive (false);
					if (lvl>=5) {
						cadeado.SetActive (false);
						scene = "Netuno";
					}else {
						cadeado.SetActive (true);
						scene = "";
					}
					break;

				case "Plutão":
					cm.transform.LookAt (planetas [8]);
					Camera.main.fieldOfView = 5;
					txt.text = "Pluto";
					painel.SetActive (true);
					button.SetActive (false);
					if (lvl >= 0) {
						cadeado.SetActive (false);
						scene = "Plutão";
					} else {
						scene = "";
					}

					break;
				}
			}
		}

	
	}
	public void close(){
		Camera.main.fieldOfView = 70;
		cm.transform.LookAt (planetas [9]);
		painel.SetActive (false);
		button.SetActive (true);
		scene = "";

	}
	public void Play()
	{ 
		if (scene=="Plutão") {
			SceneManager.LoadScene (scene);
		}
		if (scene=="Venus") {
			SceneManager.LoadScene (scene);
		}
		if (scene=="Marte") {
			SceneManager.LoadScene (scene);
		}
		if (scene=="Júpiter") {
			SceneManager.LoadScene (scene);
		}
		if (scene=="Saturno") {
			SceneManager.LoadScene (scene);
		}
		if (scene=="Urano") {
			SceneManager.LoadScene (scene);
		}
		if (scene=="Netuno") {
			SceneManager.LoadScene (scene);
		}
		if (scene=="Terra") {
			SceneManager.LoadScene (scene);
		}
		if (scene=="Mercurio") {
			SceneManager.LoadScene (scene);

		}
	}
}


