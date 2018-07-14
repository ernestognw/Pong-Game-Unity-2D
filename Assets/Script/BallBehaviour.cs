using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

  public Transform paddle;
  public bool gameStarted = false;
  public Rigidbody2D rigidbody2DBall;
  float posDif = 0;

	// Use this for initialization
	void Start () {
		rigidbody2DBall = GetComponent<Rigidbody2D>();
		rigidbody2DBall.Sleep();
    posDif = paddle.position.x - transform.position.x;    
	}
	
	// Update is called once per frame
	void Update () {
    if(!gameStarted){
	  	transform.position = new Vector3(paddle.position.x - posDif, paddle.position.y, paddle.position.z);
      if(Input.GetMouseButtonDown(0)){
        rigidbody2DBall.WakeUp();
        rigidbody2DBall.velocity = new Vector2(15,8);
        gameStarted = true;
      }
    }

	}
}
