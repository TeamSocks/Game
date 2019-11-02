using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ChickenTextShow : MonoBehaviour {

	public Text txt_Dialgue;
	private bool click = true;

/* void OnOff(bool _flag)
	{
		txt_Dialgue.gameObject.SetActive(_flag);
	}
*/
	public
	void Update () {
		if(click) {
			txt_Dialgue.gameObject.SetActive(true);
			Debug.Log("ture");
			click = false;
		}else {
			txt_Dialgue.gameObject.SetActive(false);
			Debug.Log("ㄴ");
			click = true;
		}
	}
}
