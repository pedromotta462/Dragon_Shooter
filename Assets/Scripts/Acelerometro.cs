using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acelerometro : MonoBehaviour {
	//Rigidbody rb;
	Camera cam;
	public Quaternion rot;
	public float w;
	// Use this for initialization
	void Start () {
		rot = Quaternion.identity;
		//rb = GetComponent<Rigidbody> ();
		cam = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		float test = Input.acceleration.y;
		//Vector3 acele =Input.acceleration;
		//acele.x = Input.acceleration.y;
		//acele.y = Input.acceleration.x;
		//transform.rotation = new Quaternion(acele.x,0,0,w);	
		//rot.eulerAngles=Input.acceleration*w;
		transform.Rotate(test*w,0,0);
		//RotateCamera sla = rot;
	}
}
