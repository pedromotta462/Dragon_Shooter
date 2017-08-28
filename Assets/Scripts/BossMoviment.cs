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
	public static bool go;
	float vida=5;
	PM life;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		life = player.GetComponent<PM> ();
		vida+=life.vidaBoss;
		go = false;
		inimigo = GetComponent<Rigidbody> ();
		segue = GameObject.FindGameObjectWithTag ("Earth").transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
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
		go = true;
	}
}
