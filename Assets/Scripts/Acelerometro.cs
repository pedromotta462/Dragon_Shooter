
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acelerometro : MonoBehaviour {
	
	public float w;
	// Update is called once per frame
	void Update () {
		float test = Input.acceleration.y;
		transform.Rotate(test*w,0,0);
	
	}

}
