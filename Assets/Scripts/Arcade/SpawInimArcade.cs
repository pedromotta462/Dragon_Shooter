using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawInimArcade : MonoBehaviour {
	public GameObject obj;
	public Transform um,um1,dois,dois2,tres,tres3,quatro,quatro4;
	public float minTime , maxTime ;
	public bool status;
	int PosiX ;
	public GameObject boss;
	public bool boss1,boss2,boss3;
	Vector3[] position=new Vector3[4];
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
				if (boss1) {
					Instantiate (boss, position [0], Quaternion.identity);
					boss1 = false;
					Debug.Log ("pegou porraaaaaaaa");
				}
				if (BossMov.go) {
					Instantiate (obj, position [1], Quaternion.identity);
					EM.speed = 0.3f;
					minTime = 2;
					maxTime = 7;
				}

			}
			if (Score.pontos>200 && Score.pontos<=300) {
				if (boss2) {
					Instantiate (boss, position [1], Quaternion.identity);
					boss2 = false;
					BossMov.go = false;
						}
				if (BossMov.go) {
					Instantiate (obj, position [2], Quaternion.identity);
					minTime = 1;
					maxTime = 5;
				}
			
			}
			if (Score.pontos>300 && Score.pontos<=400) {
				if (boss3) {
					Instantiate (boss, position [2], Quaternion.identity);
					boss3 = false;
					BossMov.go = false;
				}
				if (BossMov.go) {
					Instantiate (obj, position [3], Quaternion.identity);
					EM.speed = 0.4f;
					maxTime = 4;
				}

			}
			if (Score.pontos>400 && Score.pontos<=500) {
				PosiX = Random.Range (0, 4);
				maxTime = 3;
				Instantiate (obj, position [PosiX], Quaternion.identity);
			}
		}

	}

	public void MudarEstadoDoSpawn()
	{
		status = !status;
	}
}
