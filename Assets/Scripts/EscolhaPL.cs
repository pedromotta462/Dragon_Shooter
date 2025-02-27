﻿using System.Collections;
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
	public List<Material> materials;

	// Use this for initialization
	void Start () {
		//level que o player está e o mini painel na seleção 
		lvl=PlayerPrefs.GetInt ("Level");
		painel.SetActive (false);
		button.SetActive (true);
		cadeado.SetActive (false);
	}

	void Update ()
	{
		//escolha de planetas pelo toque, a mudança de zoom da camera para focar o planeta selecionado e mostrar o painel junto com o cadeado se ele estiver bloqueado
		//preenche a string que define a fase que player vai ir 
		RaycastHit hit;
		if (Input.GetMouseButtonDown (0)) {
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
						materials[2].color = Color.white;
						}	 else {
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
					if (PlayerPrefs.GetInt ("Terra") == 1) {//
						cadeado.SetActive (false);
						scene = "Terra";
						materials[3].color = Color.white;
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
						if (PlayerPrefs.GetInt ("Marte") == 1) {//
						Debug.Log ("ue");
						cadeado.SetActive (false);
						scene = "Marte";
						materials[4].color = Color.white;
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
					if (PlayerPrefs.GetInt ("Jupiter") == 1) {//
						cadeado.SetActive (false);
						scene = "Júpiter";
						materials[5].color = Color.white;
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
					if (PlayerPrefs.GetInt ("Saturno") == 1) {//
						cadeado.SetActive (false);
						scene = "Saturno";
						materials[6].color = Color.white;
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
					if (PlayerPrefs.GetInt ("Urano") == 1) {//
						cadeado.SetActive (false);
						scene = "Urano";
						materials[7].color = Color.white;
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
					if (PlayerPrefs.GetInt ("Netuno") == 1) {//
						cadeado.SetActive (false);
						scene = "Netuno";
						materials[8].color = Color.white;
					} else {
						cadeado.SetActive (true);
						scene = "";
					}
						break;
				
				}
			}
		}
	}

	
	//zera a string quando fechar o painel do planeta selecionado 
	public void close(){
		Camera.main.fieldOfView = 72;
		cm.transform.LookAt (planetas [9]);
		painel.SetActive (false);
		button.SetActive (true);
		scene = "";

	}
	//vai para cena de acordo com a string do planeta 
	public void Play()
	{ 
		if (scene=="Venus") {
			
			AsyncOperation load = SceneManager.LoadSceneAsync ("Load");
		}
		if (scene=="Marte") {
			
			AsyncOperation load = SceneManager.LoadSceneAsync ("Load");
		}
		if (scene=="Júpiter") {
			
			AsyncOperation load = SceneManager.LoadSceneAsync ("Load");
		}
		if (scene=="Saturno") {
			
			AsyncOperation load = SceneManager.LoadSceneAsync ("Load");
		}
		if (scene=="Urano") {

			AsyncOperation load = SceneManager.LoadSceneAsync ("Load");
		}
		if (scene=="Netuno") {
			
			AsyncOperation load = SceneManager.LoadSceneAsync ("Load");
		}
		if (scene=="Terra") {
			
			AsyncOperation load = SceneManager.LoadSceneAsync ("Load");
		}
		if (scene=="Mercurio") {
			
			AsyncOperation load = SceneManager.LoadSceneAsync ("Load");

		}
	}


}


