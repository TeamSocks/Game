using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
	[TextArea]
	public string dialoquetext;
	public Sprite cg;
}


public class Talk : MonoBehaviour {

//SpriteRenderer
	[SerializeField] private SpriteRenderer sprite_StandingCG;
	[SerializeField] private SpriteRenderer sprite_DialogueBox;
	[SerializeField] private Text txt_Dialgue;
	
	private bool isDialogue = false;

	private int count = 0;

	[SerializeField] private Dialogue[] dialogue;

	public void ShowDialogue()
	{
		OnOff(true);
		count = 0;
		NextDialogue();
	}

	public void OnOff(bool _flag)
	{
		sprite_DialogueBox.gameObject.SetActive(_flag);
		sprite_StandingCG.gameObject.SetActive(_flag);
		txt_Dialgue.gameObject.SetActive(_flag);
		isDialogue = _flag;
	}
/* 
	public void HideDialogue()
	{
		sprite_DialogueBox.gameObject.SetActive(false);
		sprite_StandingCG.gameObject.SetActive(false);
		txt_Dialgue.gameObject.SetActive(false);
		isDialogue = false;
	}
*/

	public void NextDialogue()
	{
		txt_Dialgue.text = dialogue[count].dialoquetext;
		sprite_StandingCG.sprite = dialogue[count].cg;
		count++;
	}

	
	void Update () {
		if(isDialogue)
		{
			if(Input.GetKeyDown(KeyCode.Space))
			{
				if(count < dialogue.Length)
					NextDialogue();
				else
					OnOff(false);
			}
		}	
	}
}
