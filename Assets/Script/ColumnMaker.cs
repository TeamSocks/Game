using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMaker : MonoBehaviour {

	public GameObject Column;
	private float nowTime;
	private float makeTime = 2f;

	// Use this for initialization
	void Start () {
		nowTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time - nowTime > makeTime)
		{
			nowTime = Time.time;
			GameObject temp = Instantiate(Column);
			temp.transform.parent = gameObject.transform;

			temp.transform.localPosition = new Vector3(-gameObject.transform.localPosition.x +5,0,0);
		}
	}
}
