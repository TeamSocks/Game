using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyButton : MonoBehaviour {

	public float characterJump = 8f;

	public GameObject EndPannel;

	void Update () {

		if(!GameManager.playerDie) {
			if(Input.GetMouseButtonDown(0)) // jump
			{
				GetComponent<Rigidbody2D>().velocity = new Vector3(0, characterJump, 0);

				transform.rotation = Quaternion.Euler(0, 0, 30f);

			}
			transform.Rotate(0, 0, -1f);
		}
		
	}

	private void OnCillisonEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag.CompareTo("Pipe_Ground") == 0)
		{
			GameManager.playerDie = true;

			EndPannel.SetActive(true);
		}
	}
}

