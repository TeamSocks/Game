using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpadateDetect : MonoBehaviour {

	private void OnTriggerExit2D(Collider2D collision) 
	{
		if(collision.gameObject.tag.CompareTo("Player") == 0)
		{
			Debug.Log("점수"+GameManager.score);
			GameManager.score += 1;
		}
	}
}
