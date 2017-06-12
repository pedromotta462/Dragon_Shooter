using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotArcade : MonoBehaviour {
	public float speed;
	Rigidbody rb;
	 ScoreArcade plus;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		plus = GetComponent<ScoreArcade> ();
		AudioSource som = GetComponent<AudioSource> ();
		som.Play ();

	}

	// Update is called once per frame
	void FixedUpdate () {

		rb.MovePosition(rb.position + transform.forward * speed);

	}
	void OnCollisionEnter (Collision coll)
	{ 

		if (coll.gameObject.tag == "Inimigo") {
			Destroy (coll.gameObject);
			Destroy (gameObject);
			plus.pontos += 10;
			plus.dificuldade += 10;
		}

	}
}
