using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text 사용하기 때문에

public class BurgerCountUp : MonoBehaviour {

	int burgerCount;

	public GameObject burgerUpButton;
	public Text count;

	void Start () {
		count.text = "0";
	}
	
	void Update () {
		
	}

	public void Click() {
		burgerCount++;
		count.text = burgerCount.ToString();
		Debug.Log("burgerCount "+burgerCount);
	}
}
