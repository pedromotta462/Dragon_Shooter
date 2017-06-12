using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EscolhaCena : MonoBehaviour {
	public bool arcade;

	// Use this for initialization
	void Start () {
		arcade = false;

	}
	public void troca(int x){
		SceneManager.LoadScene (x);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
