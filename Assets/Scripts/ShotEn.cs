﻿	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEn : MonoBehaviour {
	public Rigidbody shot;
	public bool boss;
	PM dificuldade;
	GameObject player,world;
	// tiro do inimigo em direção ao planeta se for o boss e entrar no range do player vai no player 
	void Start () {
		world=GameObject.FindWithTag("Earth");
		player = GameObject.FindWithTag ("Player");
		dificuldade = player.GetComponent<PM> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Time.timeScale==1) {
			if (boss == false) {
				shot.MovePosition (shot.position + transform.forward * dificuldade.vShotIni);
				transform.LookAt (world.transform);
			}
			shot.MovePosition (shot.position + transform.forward * dificuldade.vShotIni);

		}
}


			
		
	
}
