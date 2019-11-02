using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChickenSceneScript : MonoBehaviour {

	public void ChickenSceneChange() {
		Debug.Log("버튼눌림");
		SceneManager.LoadScene("Chicken");
	}
}
