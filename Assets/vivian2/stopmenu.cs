using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stopmenu : MonoBehaviour {
	public GameObject menu;
	public string scene;
	// Use this for initialization
	/*void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}*/

	public void OnStop(){
		Time.timeScale = 0;
		menu.SetActive (true);

	}
	public void OnResume(){
		Time.timeScale = 1f;
		menu.SetActive (false);
	}
	public void OnRestart(){
		countdown.timer = 300;
		Time.timeScale = 1f;
		Application.LoadLevel(scene);
	}
}

