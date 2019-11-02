using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour {

	public float pipeSpeed = 1f;

	private void Update()
	{
		 //if문 하나 추가
        if (!GameManager.playerDie)
        {
            //x축 방향으로 이동시켜
            transform.Translate(-pipeSpeed * Time.deltaTime, 0, 0);

            //오브젝트 Destory하는 방법 중 하나
            if (transform.position.x <= -5f)
            {
                Destroy(gameObject);
            }
        }   

	}

}
