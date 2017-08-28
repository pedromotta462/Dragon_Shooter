 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpawInimArcade : MonoBehaviour {
	public GameObject obj;
	public Transform um,um1,dois,dois2,tres,tres3,quatro,quatro4;
	public float minTime , maxTime ;
	public bool status,fasesfinais;
	int PosiX,cont,spaw ;
	public GameObject boss;
	public bool spawboss;
	Vector3[] position=new Vector3[4];
	public static List<EM> enemy;
	int WTF;
	public int nEnemy;

	public string nextscene;

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

			position [0] = new Vector3 (Random.Range (um.position.x, um1.position.x), -3.5f, um.position.z);
			position [1] = new Vector3 (Random.Range (dois.position.x, dois2.position.x), -3.5f,dois.position.z);
			position [2] = new Vector3 ( tres.position.x, -3.5f,(Random.Range (tres.position.z, tres3.position.z)));
			position [3] = new Vector3 ( quatro.position.x, -3.5f,(Random.Range (tres.position.z, tres3.position.z)));

			yield return new WaitForSeconds (Random.Range(minTime,maxTime));
			//Espama um número de inimigos

			if (cont <= nEnemy && spaw==0) {
				cont++;
				if (fasesfinais) {
					if (WTF==0) {
						WTF++;
						PosiX = Random.Range (0, 4);
					}
						Instantiate (obj, position [PosiX], Quaternion.identity);
				} else {
					Instantiate (obj, position [0], Quaternion.identity);
				}		

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
				if (fasesfinais) {
					if (WTF==1) {
						WTF++;
						PosiX = Random.Range (0, 4);
					}
					Instantiate (obj, position [PosiX], Quaternion.identity);
				} else {
					Instantiate (obj, position [1], Quaternion.identity);
				}		
				EM.speed = 0.3f;
				cont++;
				minTime = 1;
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
				if (fasesfinais) {
					if (WTF==2) {
						WTF++;
						PosiX = Random.Range (0, 4);
					}
					Instantiate (obj, position [PosiX], Quaternion.identity);
				} else {
					Instantiate (obj, position [2], Quaternion.identity);
				}		
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
				if (fasesfinais) {
					if (WTF==3) {
						WTF++;
						PosiX = Random.Range (0, 4);
					}
					Instantiate (obj, position [PosiX], Quaternion.identity);
				} else {
					Instantiate (obj, position [3], Quaternion.identity);
				}		
				cont++;
			
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
			
				Instantiate (obj, position [PosiX], Quaternion.identity);
				}
			//Espama o boss
			if (enemy.Count==0 && cont >= nEnemy && spaw == 4) {
				if (spawboss) {
							PosiX = Random.Range (0, 4);
							spaw++;
						Instantiate (boss, position [PosiX], Quaternion.identity);
					BossMoviment.go = false;
					}
				Debug.Log ("ta ai: " + spaw);
			}
			if (BossMoviment.go && spaw >= 1) {
				SceneManager.LoadScene (nextscene);
			}
		}
	}

	public void MudarEstadoDoSpawn()
	{
		status = !status;
	}
}
