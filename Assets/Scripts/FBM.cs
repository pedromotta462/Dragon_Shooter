using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FBM : MonoBehaviour {
    
	public Slider sl;
	Rigidbody shot;
	float gambiarra;
	float gambiara;
	public GameObject reta;
	public Transform fpscontroller;


	// Use this for initialization
	void Start () {
		



	}
		

	// Update is called once per frame
	void Update () {
		if (sl.value<1) {
			gambiara += Time.deltaTime;
			if (gambiara>=1) {
				sl.value -= 0.1f;
				gambiara = 0;
			}
		}
		if (sl.value>=1) {
			gambiarra += Time.deltaTime;
			if (gambiarra>=5) {
				sl.value = 0;
				gambiarra = 0;
			}
		}

			
		}

	public void click(){
		if (sl.value < 1f) {
		    Quaternion q = Quaternion.Euler (fpscontroller.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0f);
			sl.value += 0.2f; 
			shot = (Instantiate (reta, transform.position, q) as GameObject).GetComponent<Rigidbody> ();
		

		}
	}




		void OnCollisionEnter(Collision coll){
			if (coll.gameObject.tag == "Inimigo") {
				Destroy (coll.gameObject);
			Score.pontos = Score.pontos + 25;

			}
	}
}

