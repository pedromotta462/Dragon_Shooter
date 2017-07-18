using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEn : MonoBehaviour {
	public Rigidbody shot;
	public float speed;
	public Transform world;
	public bool boss;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale==1) {
			if (boss == false) {
				shot.MovePosition (shot.position + transform.forward * speed);
				transform.LookAt (world);
			}
			shot.MovePosition (shot.position + transform.forward * speed);

		}
}


			
		
	
}
