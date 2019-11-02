using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyGameSceneScript : MonoBehaviour {

	public void FlyGameSceneChange() {
		Debug.Log("버튼눌림");
		SceneManager.LoadScene("FlyGame");
	}
}
