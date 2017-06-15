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
		if (boss == false) {
			transform.LookAt (world.position);
			shot.MovePosition(shot.position + transform.forward * speed);
		}

		shot.MovePosition(shot.position + transform.forward * speed);


}


			
		
	
}
