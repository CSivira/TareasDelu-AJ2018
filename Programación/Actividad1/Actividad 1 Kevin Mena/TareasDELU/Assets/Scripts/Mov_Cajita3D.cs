using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Cajita3D : MonoBehaviour {

	[SerializeField] float maxSpeed = 15f;
	Vector2 velocidadActual = new Vector2();
	Rigidbody rb;

	void Awake () {
		rb = GetComponent<Rigidbody>();
	}

	void Update() {
		velocidadActual.x = Input.GetAxis("Horizontal") * maxSpeed;
		velocidadActual.y = Input.GetAxis("Vertical") * maxSpeed;
	}

	void FixedUpdate () {
		Move();
	}

	void Move() {
		rb.velocity = new Vector3(velocidadActual.x, rb.velocity.y, velocidadActual.y);
	}	
}
