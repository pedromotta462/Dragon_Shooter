using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
	public Text txt,ranked;
	bool surva;
	int rank,pontos;
	// Use this for initialization
	void Start () {
		pontos = PlayerPrefs.GetInt ("Score");
		rank = PlayerPrefs.GetInt ("Rank");
		surva = PlayerPrefs.GetInt ("Survival") == 1;
		if (surva) {
			txt.text = "Score final: " + PlayerPrefs.GetInt ("Score");
		 if (rank > pontos) {
				ranked.text = "New Rank: " + PlayerPrefs.GetInt ("Rank");
			} else {
				ranked.text = "Rank Atual: " + PlayerPrefs.GetInt ("Rank");
		
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
