using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneScript : MonoBehaviour {

	public void GameSceneChange() {
		Debug.Log("버튼눌림");
		SceneManager.LoadScene("Game");
	}
}
