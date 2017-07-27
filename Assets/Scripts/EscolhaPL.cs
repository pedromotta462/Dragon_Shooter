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
	public GameObject painel, button;
	public static string scene;

	// Use this for initialization
	void Start () {
		lvl=PlayerPrefs.GetInt ("Level");
		painel.SetActive (false);
		button.SetActive (true);
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
						scene = "Mercurio";
					}
						break;
				case "Vênus":
					cm.transform.LookAt (planetas [1]);
					Camera.main.fieldOfView = 10;
					txt.text="Venus";
					painel.SetActive (true);
					button.SetActive (false);
					if (lvl>=3) {
						scene = "Venus";
					}

					break;

				case "Earth":
					cm.transform.LookAt (planetas [2]);
					Camera.main.fieldOfView = 10;
					txt.text = "Earth";
					painel.SetActive (true);
					button.SetActive (false);
					if (lvl>=4) {
						scene = "Terra";
					}

					break;

				case "Marte":
					cm.transform.LookAt (planetas [3]);
					Camera.main.fieldOfView =10;
					txt.text="Mars";
					painel.SetActive (true);
					button.SetActive (false);
					if (lvl>=2) {
						scene = "Marte";
					}
					break;

				case "Júpiter":
					cm.transform.LookAt (planetas [4]);
					Camera.main.fieldOfView = 20;
					txt.text="Jupiter";
					painel.SetActive (true);
					button.SetActive (false);
					if (lvl>=8) {
						scene = "Júpiter";
					}
					break;

				case "Saturno":
					cm.transform.LookAt (planetas [5]);
					Camera.main.fieldOfView = 20;
					txt.text="Saturn";
					painel.SetActive (true);
					button.SetActive (false);
					if (lvl>=7) {
						scene = "Saturno";
					}
					break;

				case "Urano":
					cm.transform.LookAt (planetas [6]);
					Camera.main.fieldOfView = 10;
					txt.text="Uranus";
					painel.SetActive (true);
					if (lvl>=6) {
						scene = "Urano";
					}
					break;

				case "Netuno":
					cm.transform.LookAt (planetas [7]);					
					Camera.main.fieldOfView = 10;
					txt.text="Neptune";
					painel.SetActive (true);
					button.SetActive (false);
					if (lvl>=5) {
						scene = "Netuno";
					}
					break;

				case "Plutão":
					cm.transform.LookAt (planetas [8]);
					Camera.main.fieldOfView = 5;
					txt.text="Pluto";
					painel.SetActive (true);
					button.SetActive (false);
					if (lvl>=0) {
						scene = "Plutão";
					}

					break;
				}
			}
		}

	
	}
	public void close(){
		Camera.main.fieldOfView = 72;
		cm.transform.LookAt (planetas [9]);
		painel.SetActive (false);
		button.SetActive (true);


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


