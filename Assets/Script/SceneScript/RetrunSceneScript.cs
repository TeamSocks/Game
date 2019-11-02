using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnSceneScript : MonoBehaviour {

	public void ReturnSceneChange() {
		Debug.Log("버튼눌림");
		SceneManager.LoadScene("Main");
	}
}
