using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FBM : MonoBehaviour {
    
	Rigidbody shot;
	public GameObject reta;
	public Transform fpscontroller;


	// Use this for initialization
	void Start () {
		



	}
		

	// Update is called once per frame


	public void click(){
		if (Folego.test==false) {
		    Quaternion q = Quaternion.Euler (fpscontroller.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0f);

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

