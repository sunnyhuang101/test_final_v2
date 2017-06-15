using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class countdown : MonoBehaviour {
	public static int timer = 300;
	public string scene;
	int min;
	int sec;
	//public GameObject ti;
	//public GameObject ni;
	// Use this for initialization
	void Start () {
		timer = 300;
		StartCoroutine (Countdown());
	}
	void Update(){
		min = timer / 60;
		sec = timer % 60;
		gameObject.GetComponent<UnityEngine.UI.Text> ().text = min + ":" + sec;
	}

	// Update is called once per frame
	IEnumerator Countdown () {
		while (timer>1) {
			timer--;
			yield return new WaitForSeconds (1);
		}
		if (timer <= 1)
			Application.LoadLevel (scene);
	}

	/*void CountdownTime(){
		while (true) {
			timer--;

		}
	}*/

}
