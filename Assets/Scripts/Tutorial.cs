using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {
	public GameObject print_1, print_2, next,menu,back;
	// Use this for initialization
	void Start () {
		print_1.SetActive (true);
		print_2.SetActive (false);
		next.SetActive (true);
		back.SetActive (false);
		menu.SetActive (false);
	}
	
	// Update is called once per frame
	public void click(){
		menu.SetActive (true);
		print_1.SetActive (false);
		print_2.SetActive (true);
		next.SetActive (false);
		back.SetActive (true);
	}
	public void click_back(){
		print_1.SetActive (true);
		print_2.SetActive (false);
		next.SetActive (true);
		back.SetActive (false);
		menu.SetActive (false);
	}
}
