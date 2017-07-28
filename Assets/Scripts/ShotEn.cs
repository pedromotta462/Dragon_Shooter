using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEn : MonoBehaviour {
	public Rigidbody shot;
	public Transform world;
	public bool boss;
	PM dificuldade;
	GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player");
		dificuldade = player.GetComponent<PM> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale==1) {
			if (boss == false) {
				shot.MovePosition (shot.position + transform.forward * dificuldade.vShotIni);
				transform.LookAt (world);
			}
			shot.MovePosition (shot.position + transform.forward * dificuldade.vShotIni);

		}
}


			
		
	
}
