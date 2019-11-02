using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class JumpGameManager : MonoBehaviour {	

	// public float cloudTime = 2f;
	public float cloudMin = -50;
	public float cloudMax = 50;

	public GameObject cloudPrefab;

	static public int score = 0;
	static public int bestScore = 0;
	public Text ScoreText;

	private void Start () {
		StartCoroutine(cloudStart());
	}
	
	private void Update () {
		ScoreText.text = score.ToString();
	}

	IEnumerator cloudStart()
	{
		do
		{
			Instantiate(cloudPrefab,
				new Vector3(Random.Range(cloudMin,cloudMax), 5f,0),
				Quaternion.Euler(new Vector3(0,0,0)));
			yield return new WaitForSeconds(5f);
		} while (true);
	}
	
}