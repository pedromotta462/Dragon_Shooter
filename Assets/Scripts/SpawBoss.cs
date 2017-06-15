using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawBoss : MonoBehaviour {
	public GameObject obj;
	public Transform um,um1,dois,dois2,tres,tres3,quatro,quatro4;
	public float minTime , maxTime ;
	public bool status;
	int PosiX ;

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
		while (true) 
		{
			position [0] = new Vector3 (Random.Range (um.position.x, um1.position.x), 0, um.position.z);
			position [1] = new Vector3 (Random.Range (dois.position.x, dois2.position.x), 0,dois.position.z);
			position [2] = new Vector3 ( tres.position.x, 0,(Random.Range (tres.position.z, tres3.position.z)));
			position [3] = new Vector3 ( quatro.position.x, 0,(Random.Range (tres.position.z, tres3.position.z)));

			yield return new WaitForSeconds (Random.Range (minTime, maxTime));
			if (status) {
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