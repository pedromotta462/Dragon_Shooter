using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour {
	public Text total;
	public int pontos;
	public float dificuldade;
	SpawInimigo spaw;
	bool survivor;


	void Start()
	{
		survivor = PlayerPrefs.GetInt ("Survival") == 1;
		spaw = FindObjectOfType<SpawInimigo> ();
		pontos = 0;
		total.text = "Score: " + pontos;
		if (survivor) {
			StartCoroutine (gg ());
		
		}
	}
	void Update(){
		if (survivor) {
			
			if (dificuldade >= 100) {
				if (spaw.maxTime > 1) {
					spaw.maxTime -= 1;
				}
				if (EM.speed < 0.6f) {
					EM.speed += 0.1f;
				}
				
				dificuldade = 0;
				Debug.Log (dificuldade);
			}
		}
		total.text = "Score: " + pontos;

	}

	void OnDestroy() {
		PlayerPrefs.SetFloat ("Score",pontos);
		PlayerPrefs.Save ();
	}

	IEnumerator gg(){
		while (true) {
			yield return new WaitForSeconds (1.5f);
			pontos = pontos + 1;
			dificuldade =dificuldade + 1;


		}

	}
		

}

