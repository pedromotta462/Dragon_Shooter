using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EscolhaPL : MonoBehaviour {

	public Camera cm;
	public float reach=9999f;
	public List<Transform> planetas;
	public Text txt;
	public GameObject painel, button;
	int scene;

	// Use this for initialization
	void Start () {
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
					scene = 10;
					break;
				case "Vênus":
					cm.transform.LookAt (planetas [1]);
					Camera.main.fieldOfView = 10;
					txt.text="Venus";
					painel.SetActive (true);
					button.SetActive (false);
					scene = 11;
					break;

				case "Earth":
					cm.transform.LookAt (planetas [2]);
					Camera.main.fieldOfView = 10;
					txt.text = "Earth";
					painel.SetActive (true);
					button.SetActive (false);
					scene = 12;
					break;

				case "Marte":
					cm.transform.LookAt (planetas [3]);
					Camera.main.fieldOfView =10;
					txt.text="Mars";
					painel.SetActive (true);
					button.SetActive (false);
					scene = 13;
					break;

				case "Júpiter":
					cm.transform.LookAt (planetas [4]);
					Camera.main.fieldOfView = 20;
					txt.text="Jupiter";
					painel.SetActive (true);
					button.SetActive (false);
					scene = 14;
					break;

				case "Saturno":
					cm.transform.LookAt (planetas [5]);
					Camera.main.fieldOfView = 20;
					txt.text="Saturn";
					painel.SetActive (true);
					button.SetActive (false);
					scene = 15;
					break;

				case "Urano":
					cm.transform.LookAt (planetas [6]);
					Camera.main.fieldOfView = 10;
					txt.text="Uranus";
					painel.SetActive (true);
					scene = 16;
					break;

				case "Netuno":
					cm.transform.LookAt (planetas [7]);					
					Camera.main.fieldOfView = 10;
					txt.text="Neptune";
					painel.SetActive (true);
					button.SetActive (false);
					scene = 17;
					break;

				case "Plutão":
					cm.transform.LookAt (planetas [8]);
					Camera.main.fieldOfView = 5;
					txt.text="Pluto";
					painel.SetActive (true);
					button.SetActive (false);
					scene = 18;
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
		SceneManager.LoadScene (scene);
	}
}


