using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GyroScope : MonoBehaviour {
	GameObject camParent;
	public Text txt;
	public float speed, inverseY;
	public Toggle markingbox;
	//public Toggle inverseYToggle;
	void Start(){
		//implementação da movimentação em todos os angulos no hard
		camParent = new GameObject ("CamParent");
		camParent.transform.position = this.transform.position;
		this.transform.parent = camParent.transform;
		Input.gyro.enabled = true;
		inverseY = 1f;

	}
	void Update(){
		//rotção para cima e baixo de acordo com a rotação definida pelo player 
		if (Time.timeScale==1) {
			if (PlayerPrefs.GetInt("Bool")==1) {
				speed = PlayerPrefs.GetFloat ("Rotação");
				this.transform.Rotate (inverseY*Input.gyro.rotationRateUnbiased.x*speed, 0, 0);
			}

			//camParent.transform.Rotate (0, Input.gyro.rotationRateUnbiased.y*speed, 0);

		}
	}
	//inverter eixo 
	public void InverseY(){
		inverseY *= -1f;
	}
	//verificação se o aparelho suporta o gyroscope
	public void Hard (string x){
		PlayerPrefs.SetInt ("Bool", 1);
		if (SystemInfo.supportsGyroscope) {
			SceneManager.LoadScene (x);
		} else {
			markingbox.isOn = false;
			txt.text="Seu andoid não possui os requisitos minímos para execução deste modo";
			
		}
	}
	public void normal(string x){
		PlayerPrefs.SetInt ("Bool", 0);
		SceneManager.LoadScene (x);
	}

}
