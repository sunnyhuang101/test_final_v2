using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasureController : MonoBehaviour {

	public AudioSource money_sound;
	private int hit = 0;
	private float alph = 1f;
	// Use this for initialization
	void Start () {
		money_sound = GameObject.FindGameObjectWithTag ("money_sound").GetComponent<AudioSource> ();

	}
	public GameObject money;
	// Update is called once per frame
	void Update () {
		
	if ((hit == 1) && (alph == 0.3f) ) {
			
			alph = alph - 0.1f;

		}
		else if ((hit == 1) ) {
			alph = alph - 0.01f;
		}
	}

	void OnTriggerEnter2D(Collider2D t){
		hit = 1;
		if (t.tag == "Player") 
		{
			money_sound.Play ();
			money.SetActive (true);
			this.gameObject.GetComponent<Renderer> ().enabled = false;

		}
	}
}
