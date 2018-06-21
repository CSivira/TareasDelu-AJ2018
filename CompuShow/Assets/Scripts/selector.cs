using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selector : MonoBehaviour {

	public GameObject lista;

	private int indice;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow) & indice == 0) indice = lista.transform.childCount-1;
		else if (Input.GetKeyDown (KeyCode.UpArrow)) indice--;

		if (Input.GetKeyDown (KeyCode.DownArrow) & indice == lista.transform.childCount-1) indice = 0;
		else if (Input.GetKeyDown (KeyCode.DownArrow)) indice++;

		var opcion = lista.transform.GetChild (indice);
		transform.position = opcion.position;
	}
}
