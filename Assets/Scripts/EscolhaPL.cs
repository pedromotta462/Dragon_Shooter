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
	public List<Material> mat;

	// Use this for initialization
	void Start () {
		lvl=PlayerPrefs.GetInt ("Level");
		painel.SetActive (false);
		button.SetActive (true);
		cadeado.SetActive (false);
	
		if (PlayerPrefs.GetInt("Marte")==1) {
			mat [1].color = Color.white;
		} else {
			mat [0].color = new Color (0.31f,0.31f,0.31f,1f);
		}
		if (PlayerPrefs.GetInt("Venus")==1) {
			mat [2].color = Color.white;
		} else {
			mat [0].color = new Color (0.31f,0.31f,0.31f,1f);
		}
		if (PlayerPrefs.GetInt("Terra")==1) {
			mat [3].color = Color.white;
		} else {
			mat [0].color = new Color (0.31f,0.31f,0.31f,1f);
		}
		if (PlayerPrefs.GetInt("Netuno")==1) {
			mat [4].color = Color.white;
		} else {
			mat [0].color = new Color (0.31f,0.31f,0.31f,1f);
		}
		if (PlayerPrefs.GetInt("Urano")==1) {
			mat [5].color = Color.white;
		} else {
			mat [0].color = new Color (0.31f,0.31f,0.31f,1f);
		}
		if (PlayerPrefs.GetInt("Saturno")==1) {
			mat [6].color = Color.white;
		} else {
			mat [0].color = new Color (0.31f,0.31f,0.31f,1f);
		}
		if (PlayerPrefs.GetInt("Jupiter")==1) {
			mat [7].color = Color.white;
		} else {
			mat [0].color = new Color (0.31f,0.31f,0.31f,1f);
		}
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
					cadeado.SetActive (false);
					scene = "Mercurio";
						
					break;
				case "Vênus":
					cm.transform.LookAt (planetas [1]);
					Camera.main.fieldOfView = 10;
					txt.text = "Venus";
					painel.SetActive (true);
					button.SetActive (false);
					if (PlayerPrefs.GetInt ("Venus") == 1) {
						cadeado.SetActive (false);
						scene = "Venus";
						mat[2].color = Color.white;
					} else {
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
					if (PlayerPrefs.GetInt ("Terra") == 1) {
						cadeado.SetActive (false);
						scene = "Terra";
						mat[3].color = Color.white;
					} else {
						cadeado.SetActive (true);
						scene = " ";
					}

					break;

				case "Marte":
					cm.transform.LookAt (planetas [3]);
					Camera.main.fieldOfView = 10;
					txt.text = "Mars";
					painel.SetActive (true);
					button.SetActive (false);
					if (PlayerPrefs.GetInt ("Marte") == 1) {
						Debug.Log ("ue");
						cadeado.SetActive (false);
						scene = "Marte";
						mat[4].color = Color.white;
					} else {
						cadeado.SetActive (true);
						scene = "";
					}
					break;

				case "Júpiter":
					cm.transform.LookAt (planetas [4]);
					Camera.main.fieldOfView = 20;
					txt.text = "Jupiter";
					painel.SetActive (true);
					button.SetActive (false);
					if (PlayerPrefs.GetInt ("Jupiter") == 1) {
						cadeado.SetActive (false);
						scene = "Júpiter";
						mat[5].color = Color.white;
					} else {
						cadeado.SetActive (true);
						scene = "";
					}
					break;

				case "Saturno":
					cm.transform.LookAt (planetas [5]);
					Camera.main.fieldOfView = 25;
					txt.text = "Saturn";
					painel.SetActive (true);
					button.SetActive (false);
					if (PlayerPrefs.GetInt ("Saturno") == 1) {
						cadeado.SetActive (false);
						scene = "Saturno";
						mat[6].color = Color.white;
					} else {
						cadeado.SetActive (true);
						scene = "";
					}
					break;

				case "Urano":
					cm.transform.LookAt (planetas [6]);
					Camera.main.fieldOfView = 10;
					txt.text = "Uranus";
					painel.SetActive (true);
					if (PlayerPrefs.GetInt ("Urano") == 1) {
						cadeado.SetActive (false);
						scene = "Urano";
						mat[7].color = Color.white;
					} else {
						cadeado.SetActive (true);
						scene = "";
					}
					break;

				case "Netuno":
					cm.transform.LookAt (planetas [7]);					
					Camera.main.fieldOfView = 10;
					txt.text = "Neptune";
					painel.SetActive (true);
					button.SetActive (false);
					if (PlayerPrefs.GetInt ("Netuno") == 1) {
						cadeado.SetActive (false);
						scene = "Netuno";
						mat[8].color = Color.white;
					} else {
						cadeado.SetActive (true);
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
		if (scene=="Venus") {
			//SceneManager.LoadScene (scene);
			AsyncOperation load = SceneManager.LoadSceneAsync ("Load");
		}
		if (scene=="Marte") {
			//SceneManager.LoadScene (scene);
			AsyncOperation load = SceneManager.LoadSceneAsync ("Load");
		}
		if (scene=="Júpiter") {
			//SceneManager.LoadScene (scene);
			AsyncOperation load = SceneManager.LoadSceneAsync ("Load");
		}
		if (scene=="Saturno") {
			//SceneManager.LoadScene (scene);
			AsyncOperation load = SceneManager.LoadSceneAsync ("Load");
		}
		if (scene=="Urano") {
			//SceneManager.LoadScene (scene);
			AsyncOperation load = SceneManager.LoadSceneAsync ("Load");
		}
		if (scene=="Netuno") {
			//SceneManager.LoadScene (scene);
			AsyncOperation load = SceneManager.LoadSceneAsync ("Load");
		}
		if (scene=="Terra") {
			//SceneManager.LoadScene (scene);
			AsyncOperation load = SceneManager.LoadSceneAsync ("Load");
		}
		if (scene=="Mercurio") {
			//SceneManager.LoadScene (scene);
			AsyncOperation load = SceneManager.LoadSceneAsync ("Load");

		}
	}
}


