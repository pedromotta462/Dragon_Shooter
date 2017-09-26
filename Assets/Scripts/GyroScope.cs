using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroScope : MonoBehaviour {
	GameObject camParent;
	public float speed;

	void Start(){
		camParent = new GameObject ("CamParent");
		camParent.transform.position = this.transform.position;
		this.transform.parent = camParent.transform;
		Input.gyro.enabled = true;


	}
	void Update(){
		if (Time.timeScale==1) {
			speed = PlayerPrefs.GetFloat ("Rotação");
			//camParent.transform.Rotate (0, Input.gyro.rotationRateUnbiased.y*speed, 0);
			this.transform.Rotate (Input.gyro.rotationRateUnbiased.x*speed, 0, 0);
		}

	}
}
