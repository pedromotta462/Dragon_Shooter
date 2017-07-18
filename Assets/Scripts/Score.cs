using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour {
	public Text total;
	public static int pontos;
	public float dificuldade;
	bool survivor;
	public static bool control = true;
	public static int rank;

	void Awake() {
		rank = PlayerPrefs.GetInt ("Rank");
	}

	void Start()
	{
		
		survivor = PlayerPrefs.GetInt ("Survival") == 1;
		pontos = 0;

		if (survivor) {
			StartCoroutine (gg ());
			total.text = "Score: " + pontos;
		}
	}
	void Update(){
		if (survivor) {
			
			if (dificuldade >= 100) {
				if (SpawInimigo.maxTime > 1) {
					SpawInimigo.maxTime -= 1;
				}
				if (EM.speed < 0.6f) {
					EM.speed += 0.1f;
				}
				
				dificuldade = 0;
				Debug.Log (dificuldade);
			}
			total.text = "Score: " + pontos;

		}


	}
	void OnDestroy(){
		PlayerPrefs.SetInt ("Score",pontos);
		PlayerPrefs.SetInt ("Rank", rank);
		PlayerPrefs.Save ();
	}


	IEnumerator gg(){
		while (true) {
			yield return new WaitForSeconds (1.5f);
			pontos = pontos + 1;
			if (control) {
				if (PlayerPrefs.GetInt("Rank")==0) {
					rank += 1;
					Debug.Log ("test");
				}

			}
			dificuldade =dificuldade + 1;


		}

	}

	}
		



