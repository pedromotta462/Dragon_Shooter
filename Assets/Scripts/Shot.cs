﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Shot : MonoBehaviour {
	public float speed;
	Score plus;
	Rigidbody rb;


	// vida do tiro e sua velocidade
	void Start () {
		rb = GetComponent<Rigidbody> ();
		plus = FindObjectOfType<Score> ();
		AudioSource som = GetComponent<AudioSource> ();
		som.Play ();
		Destroy (this.gameObject, 5f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		rb.MovePosition(rb.position + transform.forward * speed);

	}
	void OnCollisionEnter (Collision coll)
	{ 
			
		if (coll.gameObject.tag == "Inimigo") {
			Destroy (coll.gameObject);
				Destroy (gameObject);
			Score.pontos += 10;
				plus.dificuldade += 10;
			}
		 
	}

	}

