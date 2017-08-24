using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acelerometro : MonoBehaviour {
	//Rigidbody rb;
	Camera cam;
	public float w;
	// Use this for initialization
	void Start () {
		//rb = GetComponent<Rigidbody> ();
		cam = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 acele = Vector3.zero;
		acele.x = Input.acceleration.y;
		acele.y = Input.acceleration.x;
		transform.rotation = new Quaternion(acele.x,0,0,w);	


	}
}
