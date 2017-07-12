using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BossMov : MonoBehaviour {

	public Transform pl;
	Rigidbody inimigo;
	public GameObject tiro;

	public float speed;
	bool test;
	float time;

	public float vidaBoss;

	public Slider life;

	public float danoNoPlayer;

	// Use this for initialization
	void Start () {

		inimigo = GetComponent<Rigidbody> ();

		test = false;		
	}
	
	// Update is called once per frame
	void Update () {

		transform.LookAt (pl);
		inimigo.MovePosition(inimigo.position + transform.forward * speed);
		if (test) {
			
			time += Time.deltaTime;
			if (time>=5) {
				GameObject g = Instantiate (tiro, transform.position, Quaternion.identity) as GameObject;
				g.transform.LookAt (pl.position);
				time = 0;

			}
		}		
	}

	void OnTriggerEnter(Collider coll){
		if (coll.gameObject.tag=="Player") {
			test = true;
		}
	}

	void OnCollisionEnter(Collision coll){
		if (coll.gameObject.tag=="Shot") {
			Destroy (coll.gameObject);
			vidaBoss --;
			Debug.Log (vidaBoss);
			if (vidaBoss == 0) {
				Destroy (gameObject);
			}
		}
		if (coll.gameObject.tag=="Player") {
			life.value -= danoNoPlayer;
			if (life.value == 0) {
				SceneManager.LoadScene("Over");
			}
		}
	}

}
