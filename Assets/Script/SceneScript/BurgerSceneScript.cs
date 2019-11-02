using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BurgerSceneScript : MonoBehaviour {

	public void BurgerSceneChange() {
		Debug.Log("버튼눌림");
		SceneManager.LoadScene("Burger");
	}
}
