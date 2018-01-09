 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawOBS : MonoBehaviour {
	public GameObject obj;
	public Transform P1,P2,P3,P4;
	public float minTime , maxTime ;
	int PosiX,luck ;
	public static int sorte=6;

	Vector3[] position=new Vector3[2];
	// Use this for initialization
	void Start () {
		if (sorte>0) {
			sorte -= PlayerPrefs.GetInt ("Sorte");
		}

		StartCoroutine (Spawn ());
	}
	
	// Update is called once per frame
	void Update () {
		position [0] = new Vector3 (Random.Range (P1.position.x,P2.position.x), 0, P1.position.z);
		position [1] = new Vector3  (Random.Range(P3.position.x,P4.position.x ), 0, P3.position.z);

	}
	IEnumerator Spawn() {

		while (true) 
		{
			yield return new WaitForSeconds (Random.Range (minTime, maxTime));
			PosiX= Random.Range (0, 2);
			Instantiate (obj, position [PosiX], Quaternion.identity);
			luck = Random.Range (0, sorte);
			if (luck==1) {
				MoveOBS.speed = 0.5f;
			} else {
				MoveOBS.speed = -0.5f;
			}
		

		}
	}

}
