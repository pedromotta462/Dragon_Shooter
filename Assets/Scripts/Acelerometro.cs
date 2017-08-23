using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acelerometro : MonoBehaviour {
	//Rigidbody rb;
	Camera cam;
	// Use this for initialization
	void Start () {
		//rb = GetComponent<Rigidbody> ();
		cam = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		var rot = transform.rotation;
		Vector3 acele = Input.acceleration;

		cam.transform.rotation = Quaternion.Euler(acele.x,acele.y,acele.z);
	


	}
}
