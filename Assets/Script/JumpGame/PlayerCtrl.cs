using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCtrl : MonoBehaviour {
 
    public float speed = 20;
    public float characterJump = 5f;

    void Start () {
    
    }
    void Update () {
        float inputx=Input.GetAxisRaw("Horizontal");    
        transform.Translate(speed*inputx*Time.deltaTime,0,0);

        if(Input.GetKey(KeyCode.Space)) // jump
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, characterJump, 0);

            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
        transform.Rotate(0, 0, 0);
    }

}