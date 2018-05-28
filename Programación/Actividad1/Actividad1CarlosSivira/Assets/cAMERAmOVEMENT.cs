using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cAMERAmOVEMENT : MonoBehaviour {

	public GameObject follow; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (follow.transform.position.x - 3f, transform.position.y, follow.transform.position.z);
	}
}
