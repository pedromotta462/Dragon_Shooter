using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Folego : MonoBehaviour {
	ParticleSystem pp;
	public static float i,gambiarra;
	public static bool test;
	public static float folego=0.2f;
	public static float Vfolego = 0.1f;
	// Use this for initialization
	void Start () {
		folego -= PlayerPrefs.GetFloat ("Folego");
		test = false;
		i = 1;
		pp = GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		var ps = pp.main;
		ps.startLifetime = i;
		if (i<1&&i>0.05f) {
			gambiarra += Time.deltaTime;
			if (gambiarra>=1) {
				i += Vfolego;
				gambiarra = 0;
			}
		}
		if (i<=0.05f) {
			test = true;
			gambiarra += Time.deltaTime;
			if (gambiarra>=5) {
				i = 1;
				test = false;
				gambiarra = 0;
			}
		}
	}
	public void shot(){
		if (test==false) {
			i -= folego;
		}

	}
}
