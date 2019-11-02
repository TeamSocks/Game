using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour {

	public float cloudSpeed = 1f;

	private void Update()
	{
		 //if문 하나 추가
        if (!GameManager.playerDie)
        {
            //x축 방향으로 이동시켜
            transform.Translate(0, -cloudSpeed * Time.deltaTime, 0);

            //오브젝트 Destory하는 방법 중 하나
            if (transform.position.y <= -5f)
            {
                Destroy(gameObject);
            }
        }   

	}

}
