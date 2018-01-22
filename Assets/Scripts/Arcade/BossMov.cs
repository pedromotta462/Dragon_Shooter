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
	 float vidaBoss;
	public float danoNoPlayer,plusLife;

	// Use this for initialization
	void Start () {
	   inimigo = GetComponent<Rigidbody> ();
		vidaBoss = 5+plusLife;
		test = false;		
	}
	
	// movimento do boss de acordo com o on trigger 
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

	}

}
