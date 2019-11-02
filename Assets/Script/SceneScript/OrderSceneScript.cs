using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OrderSceneScript : MonoBehaviour {

	public void OrderSceneChange() {
		Debug.Log("버튼눌림");
		SceneManager.LoadScene("Order");
	}
}
