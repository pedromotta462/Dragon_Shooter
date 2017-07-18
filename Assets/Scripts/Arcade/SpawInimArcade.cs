using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpawInimArcade : MonoBehaviour {
	public GameObject obj;
	public Transform um,um1,dois,dois2,tres,tres3,quatro,quatro4;
	public float minTime , maxTime ;
	public bool status;
	int PosiX ;
	public GameObject boss;
	public bool spawboss;
	Vector3[] position=new Vector3[4];
	public static List<EM> enemy;

	void Awake() {
		enemy = new List<EM> ();
	}

	// Use this for initialization
	void Start () {
		status = true;
		StartCoroutine (Spawn ());
	}
	void Update(){
		
	}
	// Update is called once per frame
	IEnumerator Spawn() {
	while (true) {

			position [0] = new Vector3 (Random.Range (um.position.x, um1.position.x), 0, um.position.z);
			position [1] = new Vector3 (Random.Range (dois.position.x, dois2.position.x), 0,dois.position.z);
			position [2] = new Vector3 ( tres.position.x, 0,(Random.Range (tres.position.z, tres3.position.z)));
			position [3] = new Vector3 ( quatro.position.x, 0,(Random.Range (tres.position.z, tres3.position.z)));

			yield return new WaitForSeconds (Random.Range(minTime,maxTime));

			if (Score.pontos<=100) {
				Instantiate (obj, position [0], Quaternion.identity);
			
			}
			if (Score.pontos>100 && Score.pontos<=200) {
				if (spawboss) {
					
					spawboss = false;
					Instantiate (boss, position [0], Quaternion.identity);
				}
				if (BossMoviment.go) {
					Instantiate (obj, position [1], Quaternion.identity);
					EM.speed = 0.3f;
					minTime = 2;
					maxTime = 7;
				}

			}
			if (Score.pontos>200 && Score.pontos<=300) {
				if (spawboss==false) {
					Instantiate (boss, position [1], Quaternion.identity);
					spawboss = true;
					BossMoviment.go = false;
				}
				if (BossMoviment.go) {
					Instantiate (obj, position [2], Quaternion.identity);
					minTime = 1;
					maxTime = 5;
				}
			
			}
			if (Score.pontos>300 && Score.pontos<=400) {
				if (spawboss) {
					Instantiate (boss, position [2], Quaternion.identity);
					spawboss = false;
					BossMoviment.go = false;
				}
				if (BossMoviment.go) {
					Instantiate (obj, position [3], Quaternion.identity);
					EM.speed = 0.4f;
					maxTime = 4;
				}

			}
			if (Score.pontos>400 && Score.pontos<=500) {
				if (spawboss==false) {
					Instantiate (boss, position [3], Quaternion.identity);
					spawboss = true;
					BossMoviment.go = false;
				}
				if (BossMoviment.go) {
					PosiX = Random.Range (0, 4);
					maxTime = 3;
					int cont = 0;
					if (cont<=20) {
						Instantiate (obj, position [PosiX], Quaternion.identity);
						cont += 1;
					}
				}

			}
			if (Score.pontos>500) {
				if (enemy.Count == 0) {
					PosiX = Random.Range (0, 4);
					Instantiate (boss, position [PosiX], Quaternion.identity);
					BossMoviment.go = false;
				}
				if (BossMoviment.go) {
					SceneManager.LoadScene (9);
				}
			}
		}

	}

	public void MudarEstadoDoSpawn()
	{
		status = !status;
	}
}
