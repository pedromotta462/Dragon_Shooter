using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EM : MonoBehaviour {
	public Transform world;
	Rigidbody inimigo;
	public GameObject tiro;

	public static float speed;
	public bool test;
	float time;

	// Use this for initialization
	void Start () {
		inimigo = GetComponent<Rigidbody> ();

		test = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.LookAt (world);
		inimigo.MovePosition(inimigo.position + transform.forward * speed);
		if (test) {
			time += Time.deltaTime;
			if (time>=5) {
				Instantiate (tiro, transform.position, Quaternion.identity);
	          time = 0;
			
			}
		}
	}
	void OnTriggerEnter(Collider coll){
		if (coll.gameObject.tag=="Sentido") {
			test = true;
		}
	}


}
