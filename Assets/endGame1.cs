using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D colInfo)
	{
		if (colInfo.CompareTag("enemy") || colInfo.CompareTag("road") ||colInfo.CompareTag("box") )
		{//Collidable
			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			Application.LoadLevel("gameover2");
			countdown.timer = 300;
		}
	}
}
