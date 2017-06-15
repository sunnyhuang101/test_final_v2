using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyController : MonoBehaviour {

	public AudioSource  bomb_sound;
	private float alph = 1f;
	private int play = 0;
	// Use this for initialization
	void Awake () {
		bomb_sound = GameObject.FindGameObjectWithTag ("bomb_sound").GetComponent<AudioSource> ();
		this.gameObject.SetActive (false);
	}
	void Start(){
		
	}
	// Update is called once per frame
	void Update () {
		if (alph > 0.3f) {
			alph = alph - 0.01f;

		} else if ((play==0) && (alph <= 0.3f)) {
			bomb_sound.Play ();
			Debug.Log ("bomb");
			play = 1;
		}
	}
}
