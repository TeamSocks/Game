using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickerGameSceneScript : MonoBehaviour {

	public void ClickerGameSceneChange() {
		Debug.Log("버튼눌림");
		SceneManager.LoadScene("ClickerGame");
	}
}
