using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

  public Transform paddle;
  private bool gameStarted = false;
  public Rigidbody2D rigidbody2DBall;

	// Use this for initialization
	void Start () {
		rigidbody2DBall = GetComponent<Rigidbody2D>();
		rigidbody2DBall.Sleep();
	}
	
	// Update is called once per frame
	void Update () {
    if(!gameStarted){
      float posDif = paddle.position.x - transform.position.x;
	  	transform.position = new Vector3(paddle.position.x - posDif, paddle.position.y, paddle.position.z);
      if(Input.GetMouseButtonDown(0)){
        rigidbody2DBall.WakeUp();
        rigidbody2DBall.velocity = new Vector2(15,8);
        gameStarted = true;
      }
    }

	}
}
