using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour {
	public Text total;
	public static int pontos;
	public float dificuldade;
	public static bool control = true;
	public static int rank;
	PM bonus;
	void Awake() {
		rank = PlayerPrefs.GetInt ("Rank");
	}

	void Start()
	{
		bonus = GetComponent<PM> ();

		pontos = 0;

		if (PlayerPrefs.GetInt ("Survival") == 1) {
			total.text = "Score: " + pontos;
			StartCoroutine (gg ());
		}
	}
	void Update(){
		if (PlayerPrefs.GetInt ("Survival") == 1) {
			if (dificuldade >= 100) {
				if (SpawInimigo.maxTime > 1) {
					SpawInimigo.maxTime -= 1;
				}
				if (EM.speed < 0.8f) {
					EM.speed += 0.1f;
				}
				if (bonus.cadenciaShot<=3) {
					bonus.cadenciaShot -= 1;
				}
				if (bonus.vShotIni<=8) {
					bonus.vShotIni += 0.5f;
				}
				dificuldade = 0;
				Debug.Log (dificuldade);
			}


		}


	}
	void OnDestroy(){
		PlayerPrefs.SetInt ("Score",pontos);
		PlayerPrefs.SetInt ("Rank", rank);
		PlayerPrefs.Save ();
	}


	IEnumerator gg(){
		while (true) {
			total.text = "Score: " + pontos;
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
		



