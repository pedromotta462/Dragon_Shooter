using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour {
	public Text txt,ranked;
	bool surva;
	int rank,pontos;

	//game over survival com o rank e sua pontuação 
	void Start () {
		Score.control = false;
		surva = PlayerPrefs.GetInt ("Survival") == 1;
		if (surva) {
			txt.text = "Final Score : " + PlayerPrefs.GetInt ("Score");
			if (Score.pontos>PlayerPrefs.GetInt("Rank")) {
				PlayerPrefs.SetInt ("Rank", PlayerPrefs.GetInt ("Score"));
				ranked.text = "New Rank: " + (PlayerPrefs.GetInt ("Rank"));
				} else {
				ranked.text = "Rank: " + PlayerPrefs.GetInt ("Rank");
		
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void click(){
		if (surva) {
			SceneManager.LoadScene ("Game");
		} else {
			SceneManager.LoadScene (EscolhaPL.scene);
		}
	}
}
