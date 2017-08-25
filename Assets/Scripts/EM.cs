using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EM : MonoBehaviour {
	

	Rigidbody inimigo;
	public GameObject tiro,world;
	GameObject player;
	public static float speed=0.2f;
	public bool test; 
	public float time;
	PM dificuldade;

	// Use this for initialization
	void Start () {


		world=GameObject.FindWithTag("Earth");
		player=GameObject.FindWithTag("Player");
		inimigo = GetComponent<Rigidbody> ();
		dificuldade = player.GetComponent<PM> ();
		test = false;

	}
	void Awake() {
		if (PlayerPrefs.GetInt("Survival") == 0) {
			SpawInimArcade.enemy.Add (this);	
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale==1) {
			transform.LookAt (world.transform);
			inimigo.MovePosition (inimigo.position + transform.forward * (speed+ dificuldade.vInimigo));
			if (test) { 
				time += Time.deltaTime;
				if (time >= dificuldade.cadenciaShot) {
					Instantiate (tiro, transform.position, Quaternion.identity);
					time = 0;
				}
			}
		}
	}
	void OnTriggerEnter(Collider coll){
		if (coll.gameObject.tag=="Sentido") {
			test = true;
		}
	}

	void OnDestroy(){
		if (PlayerPrefs.GetInt("Survival") == 0) {
			SpawInimArcade.enemy.RemoveAt (0);
		}
			
	}




}
