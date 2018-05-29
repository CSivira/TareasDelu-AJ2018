using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Cajita2D : MonoBehaviour {

	[SerializeField] float maxSpeed = 15f;
	float velocidadActual = 0f;
	Rigidbody rb;

	void Awake () {
		rb = GetComponent<Rigidbody>();
	}

	void Update() {
		velocidadActual = Input.GetAxis("Horizontal") * maxSpeed;
	}

	void FixedUpdate () {
		Move();
	}

	void Move() {
		rb.velocity = new Vector3(velocidadActual, rb.velocity.y, rb.velocity.z);
	}	
}
