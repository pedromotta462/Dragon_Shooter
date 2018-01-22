using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FBM : MonoBehaviour {
    
	Rigidbody shot;
	public GameObject reta;
	public Transform fpscontroller;
	//spaw do tiro e para que ele saia em linha reta da mira idependente da posição do player 
	public void click(){
		if (Folego.condicional==false) {
		    Quaternion q = Quaternion.Euler (fpscontroller.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0f);

			shot = (Instantiate (reta, transform.position, q) as GameObject).GetComponent<Rigidbody> ();
		

		}
	}
	//quando o tiro colidir destruir o inimigo e adicionar pontos no survival 
		void OnCollisionEnter(Collision coll){
			if (coll.gameObject.tag == "Inimigo") {
				Destroy (coll.gameObject);
			Score.pontos = Score.pontos + 25;

			}
	}
}

