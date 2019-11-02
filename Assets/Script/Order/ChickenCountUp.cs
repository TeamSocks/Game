using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text 사용하기 때문에

public class ChickenCountUp : MonoBehaviour {

	int chickenCount;

	public GameObject chickenUpButton;
	public Text count;

	void Start () {
		count.text = "0";
	}
	
	void Update () {
		
	}

	public void Click() {
		chickenCount++;
		count.text = chickenCount.ToString();
		Debug.Log("chickenCount "+chickenCount);
	}
}
