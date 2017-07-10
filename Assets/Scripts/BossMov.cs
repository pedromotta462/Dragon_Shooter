using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BossMov : MonoBehaviour {

	public Vector3 segue;
	Rigidbody inimigo;
	public GameObject tiro;
	public float speed;
	float time;
	public float vidaBoss;
	PM life;
	public float danoNoPlayer;
	public static bool go;

	// Use this for initialization
	void Start () {
		go = false;
		life = FindObjectOfType<PM> ();
		inimigo = GetComponent<Rigidbody> ();
		segue = GameObject.FindGameObjectWithTag ("Earth").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale==1) {
			transform.LookAt (segue);
			inimigo.MovePosition (inimigo.position + transform.forward * speed);
			time += Time.deltaTime;
			if (time >= 3) {
				GameObject g = Instantiate (tiro, transform.position, Quaternion.identity) as GameObject;
				g.transform.LookAt (segue);
				time = 0;
			}
		}
	}

	void OnTriggerEnter(Collider coll){
		if (coll.gameObject.tag=="Player") {
			segue = GameObject.FindGameObjectWithTag ("Player").transform.position;
		} 
	}

	void OnCollisionEnter(Collision coll){
		if (coll.gameObject.tag=="Shot") {
			Destroy (coll.gameObject);
			vidaBoss --;
		if (vidaBoss == 0) {
				Destroy (gameObject);
			}
		}
		if (coll.gameObject.tag=="Player") {
			life.sl.value -= danoNoPlayer;

		}
	}

	void OnTriggerExit(Collider coll){
		if (coll.gameObject.tag=="Player") {
			Debug.Log ("conmt");
			segue = GameObject.FindGameObjectWithTag ("Earth").transform.position;
		}
	}


	void OnDestroy(){
		go = true;
	}
}
