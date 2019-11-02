using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneScript : MonoBehaviour {

	public void MainSceneChange() {
		Debug.Log("버튼눌림");
		SceneManager.LoadScene("Main");
	}
}
