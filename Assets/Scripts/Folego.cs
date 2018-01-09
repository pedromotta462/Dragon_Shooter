using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Folego : MonoBehaviour {
	ParticleSystem pp;
	public static float cont,time;
	public static bool test;
	public static float folego=0.2f;
	public static float Vfolego = 0.1f;
	// Use this for initialization
	void Start () {
		folego -= PlayerPrefs.GetFloat ("Folego");
		test = false;
		cont = 1;
		pp = GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		var ps = pp.main;
		ps.startLifetime = cont;
		if (cont<1&&cont>0.05f) {
			time += Time.deltaTime;
			if (time>=1) {
				cont += Vfolego;
				time = 0;
			}
		}
		if (cont<=0.05f) {
			test = true;
			time += Time.deltaTime;
			if (time>=5) {
				cont = 1;
				test = false;
				time = 0;
			}
		}
	}
	public void shot(){
		if (test==false) {
			cont -= folego;
		}

	}
}
