using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text 사용하기 때문에

public class InGame : MonoBehaviour {

	int myNum;
	public int burgerNum;

	public GameObject meat;
	public GameObject burger;
	public Text score;

	void Start () {
		burgerNum = 10;
		score.text = "0";
	}
	
	void Update () {
		
	}

	public void Click() {
		//Debug.Log("Click!!");
		myNum++;
		score.text = myNum.ToString();
		Debug.Log("myNum: "+myNum);
		if(myNum==burgerNum) {
			burger.SetActive(true);
			meat.SetActive(false);
		}
	}
}
