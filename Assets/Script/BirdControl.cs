using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // SceneManager.LoadScene("Game") 를 사용하기 위해서 추가


public class BirdControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.SetResolution(480,800,false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) // jump
		{
			gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
			gameObject.GetComponent<Rigidbody>().AddForce(0,300,0);
		}

		if(Input.GetKeyDown(KeyCode.R)) // R를 누르면 재시작
		{
			Time.timeScale = 1;
			SceneManager.LoadScene("Game");
			//Application.LoadLevel("Game");// 현재Scene 재호출인데 위에 방법으로 사용하기
		}
	}


	void OnCollisionEnter(Collision coll) // 땅에 떨어지면 게임아웃
	{
		Debug.Log("GameOver");
		Time.timeScale = 0;// 게임 정지, 클릭 이벤트가 발생해도 캐릭터 움직임X
	}
}
