using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawInimigo : MonoBehaviour {
	
	public GameObject obj,bonus;
    public Transform position1,position1_1,position2,position2_2,position3,position3_3,position4,position4_4,position5,position5_5,position6,position6_6;
	public static float minTime , maxTime ;
	public bool status;
	int PosiX,sorte,luck ;

	 Vector3[] position=new Vector3[6];
	// Use this for initialization
	void Start () {
	    luck = PlayerPrefs.GetInt ("Sorte");
		status = true;
		StartCoroutine (Spawn ());
		minTime = 2;
		maxTime = 8;
	}
	void Update(){
	}

	// spaw dos inimigos em uma das 4 posições se for no modo hard aimenta mais duas 
	IEnumerator Spawn() {
		while (true) 
		{
			position [0] = new Vector3 (Random.Range (position1.position.x, position1_1.position.x), -3.5f, position1.position.z);
			position [1] = new Vector3 (Random.Range (position2.position.x, position2_2.position.x), -3.5f,position2.position.z);
			position [2] = new Vector3 ( position3.position.x, -3.5f,(Random.Range (position3.position.z, position3_3.position.z)));
			position [3] = new Vector3 ( position4.position.x, -3.5f,(Random.Range (position3.position.z, position3_3.position.z)));
			if (SystemInfo.supportsGyroscope) {
				position [4] = new Vector3 (Random.Range (position5.position.x, position5_5.position.x), 150, position5.position.z);
				position [5] = new Vector3 (Random.Range (position6.position.x, position6_6.position.x), -160, position6_6.position.z);
			}

			//spaw do dragão especial que da ponto de atributos 
			yield return new WaitForSeconds (Random.Range (minTime, maxTime));
			if (status) {
				PosiX = Random.Range (0,6 );
				Instantiate (obj, position [PosiX], Quaternion.identity);
				if (Score.pontos > 0 && Score.pontos < 1) {
					sorte = Random.Range (0, 20 - luck);
					if (sorte == 7) {
						Instantiate (bonus, position [PosiX], Quaternion.identity);
					}
				}
				if (Score.pontos > 200 && Score.pontos < 210) {
					sorte = Random.Range (0, 18 - luck);
					if (sorte == 7) {
						Instantiate (bonus, position [PosiX], Quaternion.identity);
					}
				}
				if (Score.pontos > 500 && Score.pontos < 520) {
					sorte = Random.Range (0, 16 - luck);
					if (sorte == 7) {
						Instantiate (bonus, position [PosiX], Quaternion.identity);
					}
				}
				if (Score.pontos > 700 && Score.pontos < 710) {
					sorte = Random.Range (0, 10 - luck);
					if (sorte == 7) {
						Instantiate (bonus, position [PosiX], Quaternion.identity);
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
