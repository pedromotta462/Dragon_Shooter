using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreArcade : MonoBehaviour {

	public Text total;
	public float pontos;
	public float dificuldade;


	void Start()
	{
		
		pontos = 0;
		total.text = "Score: " + pontos;

	}
	void Update(){
		
		total.text = "Score: " + pontos;
		PlayerPrefs.SetFloat ("Score",pontos);
		PlayerPrefs.Save ();
		
	}
		
}
