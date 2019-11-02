using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunGameSceneScript : MonoBehaviour {

	public void RunGameSceneChange() {
		Debug.Log("버튼눌림");
		SceneManager.LoadScene("RunGame");
	}
}
