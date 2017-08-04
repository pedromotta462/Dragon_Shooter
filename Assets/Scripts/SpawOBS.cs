 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawOBS : MonoBehaviour {
	public GameObject obj;
	public Transform um,dois,tres,quatro;
	public float minTime , maxTime ;
	int PosiX ;
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
		position [0] = new Vector3 (Random.Range (um.position.x,dois.position.x), 0, um.position.z);
		position [1] = new Vector3  (Random.Range(tres.position.x,quatro.position.x ), 0, tres.position.z);

	}
	IEnumerator Spawn() {

		while (true) 
		{
			yield return new WaitForSeconds (Random.Range (minTime, maxTime));
			PosiX= Random.Range (0, sorte);
			Debug.Log (PosiX);
			Instantiate (obj, position [PosiX], Quaternion.identity);
			if (PosiX==1) {
				MoveOBS.speed = 0.5f;
			} else {
				MoveOBS.speed = -0.5f;
			}
		

		}
	}

}
