 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpawInimArcade : MonoBehaviour {
	public GameObject obj;
	public Transform position1,position1_1,position2,position2_2,position3,position3_3,position4,position4_4;
	public float minTime , maxTime ;
	public bool status,fasesfinais;
	int PosiX,cont,spaw ;
	public GameObject boss;
	public bool spawboss;
	Vector3[] position=new Vector3[4];
	public static List<Enemy_movement> enemy;
	int next_spaw;
	public int nEnemy;

	public string nextscene;

	void Awake() {
		enemy = new List<Enemy_movement> ();
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

			position [0] = new Vector3 (Random.Range (position1.position.x, position1_1.position.x), -3.5f, position1.position.z);
			position [1] = new Vector3 (Random.Range (position2.position.x, position2_2.position.x), -3.5f,position2.position.z);
			position [2] = new Vector3 ( position3.position.x, -3.5f,(Random.Range (position3.position.z, position3_3.position.z)));
			position [3] = new Vector3 ( position4.position.x, -3.5f,(Random.Range (position3.position.z, position3_3.position.z)));

			yield return new WaitForSeconds (Random.Range(minTime,maxTime));
			//Espama um número de inimigos em ondas até completar os quatros cantos depois começa aleátorio mas sempre um numero já calculado de inimigos 

			if (cont <= nEnemy && spaw==0) {
				cont++;
				if (fasesfinais) {
					if (next_spaw==0) {
						next_spaw++;
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
			if (BossMoviment.x && spaw==1 && cont <= nEnemy + 2) {
				if (fasesfinais) {
					if (next_spaw==1) {
						next_spaw++;
						PosiX = Random.Range (0, 4);
					}
					Instantiate (obj, position [PosiX], Quaternion.identity);
				} else {
					Instantiate (obj, position [1], Quaternion.identity);
				}		
				Enemy_movement.speed = 0.3f;
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
					BossMoviment.x = false;
				}
			}
			//Espama um número de inimigos
			if (BossMoviment.x && spaw==2&& cont <= nEnemy + 4) {
				if (fasesfinais) {
					if (next_spaw==2) {
						next_spaw++;
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
					BossMoviment.x = false;
				}
			}
			//Espama um número de inimigos
			if (BossMoviment.x && spaw==3 && cont <= nEnemy + 6) {
				if (fasesfinais) {
					if (next_spaw==3) {
						next_spaw++;
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
					BossMoviment.x = false;
				}
			}
			//Espama um número de inimigos
			if (BossMoviment.x && spaw==4 && cont <= nEnemy + 8) {
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
					BossMoviment.x = false;
					}
				Debug.Log ("ta ai: " + spaw);
			}
			if (BossMoviment.x && spaw >= 5) {
				SceneManager.LoadScene (nextscene);
			}
		}
	}

	public void MudarEstadoDoSpawn()
	{
		status = !status;
	}
}
