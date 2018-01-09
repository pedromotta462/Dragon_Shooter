using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawBoss : MonoBehaviour {
	public GameObject obj;
	public Transform position1,position1_1,position2,position2_2,position3,position3_3,position4,position4_4;
	public float minTime , maxTime ;
	public bool status;
	int PosiX ;
	bool survival;

	Vector3[] position=new Vector3[4];
	// Use this for initialization
	void Start () {survival=PlayerPrefs.GetInt("Survival")==1;
		status = true;
		if (survival) {
			StartCoroutine (Spawn ());
		}


	}
	void Update(){
		
	}
	// Update is called once per frame
	IEnumerator Spawn() {
		while (true) 
		{
			position [0] = new Vector3 (Random.Range (position1.position.x, position1_1.position.x), 0, position1.position.z);
			position [1] = new Vector3 (Random.Range (position2.position.x, position2_2.position.x), 0,position2.position.z);
			position [2] = new Vector3 ( position3.position.x, 0,(Random.Range (position3.position.z, position3_3.position.z)));
			position [3] = new Vector3 ( position4.position.x, 0,(Random.Range (position3.position.z, position3_3.position.z)));

			yield return new WaitForSeconds (Random.Range (minTime, maxTime));
			if (Score.pontos>300) {
				PosiX= Random.Range (0, 4);
				Debug.Log (PosiX);
				Instantiate (obj, position [PosiX], Quaternion.identity);
			}
		}
	}


	public void MudarEstadoDoSpawn()
	{
		status = !status;
	}
}