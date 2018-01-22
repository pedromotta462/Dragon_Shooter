using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BossMoviment : MonoBehaviour {

	public Transform segue;
	Rigidbody inimigo;
	GameObject player;
	public GameObject tiro;
	public float speed,danoNoPlayer,time,shot;
	public static bool x;
	float vida=5;
	PM life;

	// Use this for initialization
	void Start () {
		//identificar o player e a terra, e adicionar vida no bos dependendo da dificuldade da fase  (o que já foi estabelecido em cada fase)
		player = GameObject.FindGameObjectWithTag ("Player");
		life = player.GetComponent<PM> ();
		vida+=life.vidaBoss;
		x = false;
		inimigo = GetComponent<Rigidbody> ();
		segue = GameObject.FindGameObjectWithTag ("Earth").transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//movimento do bos, ele sempre vai seguir alguem, caso entre no range do player ele segue o player caso saia ele vai para o planeta
		if (Time.timeScale==1) {
			transform.LookAt (segue.position);
			inimigo.MovePosition (inimigo.position + transform.forward * speed);
			time += Time.deltaTime;
			if (time >= shot) {
				Instantiate (tiro, transform.position, transform.rotation);
				time = 0;
			}
		}
	}

	void OnTriggerEnter(Collider coll){
		if (coll.gameObject.tag=="Player") {
			
			segue = GameObject.FindGameObjectWithTag ("Player").transform;
		} 
	}
	//dano que o bos sofre e depois sua destruição  
	void OnCollisionEnter(Collision coll){
		if (coll.gameObject.tag=="Shot") {
			Destroy (coll.gameObject);
			vida--;
			if (life.vidaBoss <= 0) {
				Destroy (gameObject);
			}
		}

	}

	void OnTriggerExit(Collider coll){
		if (coll.gameObject.tag=="Player") {
			segue = GameObject.FindGameObjectWithTag ("Earth").transform;
		}
	}


	void OnDestroy(){
		x = true;
	}
}
