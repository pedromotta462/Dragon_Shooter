﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Reset : MonoBehaviour {
	//reseta todas as fases e as pontuações dos atributos junto com todas as preferencias de volume rotação etc
	public List<GameObject> objs;
	public Slider sl;

	// Use this for initialization
	void Start () {
		sl.value = PlayerPrefs.GetFloat ("Slider");
		objs[1].SetActive (false);

	}
	void Update(){
		PlayerPrefs.SetFloat ("Slider", sl.value);
		Debug.Log (PlayerPrefs.GetFloat ("Slider"));
	}
	
	public void click2(){
		PlayerPrefs.SetInt ("Velocidade",0);
		PlayerPrefs.SetInt ("Breath", 0);
		PlayerPrefs.SetInt("Lucky", 0);
		SceneManager.LoadScene ("PLay");
		PlayerPrefs.SetInt ("Netuno", 0);
		PlayerPrefs.SetInt ("Marte", 0);
		PlayerPrefs.SetInt ("Jupiter", 0);
		PlayerPrefs.SetInt ("Venus", 0);
		PlayerPrefs.SetInt ("Terra", 0);
		PlayerPrefs.SetInt ("Saturno", 0);
		PlayerPrefs.SetInt ("Urano", 0);
		PlayerPrefs.SetInt ("Mercurio", 0);
		PlayerPrefs.SetInt ("Up", 0);
		PlayerPrefs.SetFloat ("Speed", 0);
		objs[0].SetActive (true);
		objs[1].SetActive (false);
		objs[2].SetActive (true);
		objs[3].SetActive (true);
	}
	public void click1()
	{ 
		objs [0].SetActive (false);
		objs[1].SetActive (true);
		objs[2].SetActive (false);
		objs[3].SetActive (false);
		objs [4].SetActive (false);
	}
	public void closar()
	{
		objs[0].SetActive (true);
		objs[1].SetActive (false);
		objs[2].SetActive (true);
		objs[3].SetActive (true);
		objs [4].SetActive (true);
	}
		
	}

