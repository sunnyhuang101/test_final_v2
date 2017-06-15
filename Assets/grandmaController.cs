using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grandmaController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log(Vector2.Distance (this.gameObject.transform.position, player.transform.position));
		this.transform.Translate(new Vector2 (-4, 0)*Time.deltaTime);
	}
}
