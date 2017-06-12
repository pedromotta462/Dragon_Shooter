using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEn : MonoBehaviour {
	public Rigidbody shot;
     public float speed;
	public Transform world;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (world);
			shot.MovePosition(shot.position + transform.forward * speed);
				}
		}


			
		
	

