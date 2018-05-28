using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	private float moveX;
	private float moveY;
	private float speedX;
	private float speedY;

	// Use this for initialization
	void Start () {
		transform.position = Vector3.zero;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			speedY = speedY + 0.005f;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			speedY = speedY - 0.005f;
		} else {
			speedY = 0f;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			speedX = speedX - 0.005f;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			speedX = speedX + 0.005f;
		} else {
			speedX = 0f;
		}

		transform.position = new Vector3 (transform.position.x + speedX,transform.position.y + speedY,transform.position.z);
	}
}