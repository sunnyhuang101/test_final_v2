using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dadController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


	// Update is called once per frame
	void Update () {
		
		GetComponent<Rigidbody2D> ().AddTorque (Input.GetAxisRaw("Vertical")*10);

	}
}
