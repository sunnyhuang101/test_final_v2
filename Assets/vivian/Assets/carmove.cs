using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carmove : MonoBehaviour {
	Vector2 target =new Vector2(-14, -3);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x > 16)
			transform.position = target;
		transform.Translate (new Vector2(1,0) * Time.deltaTime);

	}
}
