using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpawInimArcade : MonoBehaviour {
	public GameObject obj;
	public Transform um,um1,dois,dois2,tres,tres3,quatro,quatro4;
	public float minTime , maxTime ;
	public bool status;
	int PosiX,cont,spaw ;
	public GameObject boss;
	public bool spawboss;
	Vector3[] position=new Vector3[4];
	public static List<EM> enemy;
	public string planeta;

	public int nEnemy,dificuldade;

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
			//Espama um número de inimigos
			if (cont <= nEnemy && spaw==0) {
				cont++;
				Instantiate (obj, position [0], Quaternion.identity);
			}

			//Espama o boss
			if (enemy.Count==0 && cont >= nEnemy && spaw == 0) {
				if (spawboss) {
					spawboss = false;
					Instantiate (boss, position [0], Quaternion.identity);
					cont = 0;
					spaw++;
				}
			}
			//Espama um número de inimigos
			if (BossMoviment.go && spaw==1 && cont <= nEnemy + 2) {
				Instantiate (obj, position [1], Quaternion.identity);
				EM.speed = 0.3f;
				cont++;
				minTime = 1;
				maxTime = dificuldade+5;
			}
			//Espama o boss
			if (enemy.Count==0 && cont >= nEnemy && spaw == 1) {
				if (spawboss==false) {
					Instantiate (boss, position [1], Quaternion.identity);
					spawboss = true;
					cont = 0;
					spaw++;
					BossMoviment.go = false;
				}
			}
			//Espama um número de inimigos
			if (BossMoviment.go && spaw==2&& cont <= nEnemy + 4) {
				Instantiate (obj, position [2], Quaternion.identity);

				maxTime = dificuldade+3;
				cont++;
			}
			//Espama o boss
			if (enemy.Count==0 && cont >= nEnemy && spaw == 2) {
				if (spawboss) {
					Instantiate (boss, position [2], Quaternion.identity);
					spawboss = false;
					cont = 0;
					spaw++;
					BossMoviment.go = false;
				}
			}
			//Espama um número de inimigos
			if (BossMoviment.go && spaw==3 && cont <= nEnemy + 6) {
				Instantiate (obj, position [3], Quaternion.identity);
				cont++;
				maxTime = dificuldade+2;
			}
			//Espama o boss
			if (enemy.Count==0 && cont >= nEnemy && spaw == 3) {
				if (spawboss==false) {
					Instantiate (boss, position [3], Quaternion.identity);
					spawboss = true;
					cont = 0;
					spaw++;
					BossMoviment.go = false;
				}
			}
			//Espama um número de inimigos
			if (BossMoviment.go && spaw==4 && cont <= nEnemy + 8) {
				PosiX = Random.Range (0, 4);
				cont++;
				maxTime = dificuldade+1;
				Instantiate (obj, position [PosiX], Quaternion.identity);
				}
			//Espama o boss
			if (enemy.Count==0 && cont >= nEnemy && spaw == 4) {
					if (spawboss) {
							PosiX = Random.Range (0, 4);
					  		BossMoviment.go = false;
							Instantiate (boss, position [PosiX], Quaternion.identity);
					if (BossMoviment.go) {
						SceneManager.LoadScene (planeta);
					}
				}
			}
		}
	}

	public void MudarEstadoDoSpawn()
	{
		status = !status;
	}
}
