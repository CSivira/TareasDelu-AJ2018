using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	private float moveX;
	private float moveY;
	private float speedX;
	private float speedY;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			speedX = speedX + 0.005f;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			speedX = speedX - 0.005f;
		} else {
			speedX = 0f;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			speedY = speedY + 0.005f;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			speedY = speedY - 0.005f;
		} else {
			speedY = 0f;
		}

		transform.position = new Vector3 (transform.position.x + speedX,transform.position.y,transform.position.z + speedY);
	}
}
