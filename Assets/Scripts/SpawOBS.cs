using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawOBS : MonoBehaviour {
	public GameObject obj;
	public Transform um,dois,tres,quatro;
	public float minTime , maxTime ;
	int PosiX ;
	public MoveOBS nops; 
	Vector3[] position=new Vector3[2];
	// Use this for initialization
	void Start () {
		
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
			PosiX= Random.Range (0, 2);
			Debug.Log (PosiX);
			if (PosiX==1) {
				nops.speed = -0.5f;
			} else {
				nops.speed = 0.5f;
			}
			Instantiate (obj, position [PosiX], Quaternion.identity);

		}
	}

}
