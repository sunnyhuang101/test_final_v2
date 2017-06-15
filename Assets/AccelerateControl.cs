using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateControl : MonoBehaviour {

	public AudioSource backgroundMusic, backgroundMusicSpeedUp;

    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.tag == "Player") {
			CarController.speedF *= 3;

			backgroundMusic.mute = true;
			backgroundMusicSpeedUp.Play ();

			this.gameObject.GetComponent<Renderer> ().enabled = false;
		} //  Destroy(this);
    }
    // Use this for initialization
    void Start () {
		backgroundMusicSpeedUp	= GameObject.FindGameObjectWithTag ("backgroundMusicSpeedUp").GetComponent<AudioSource> ();
		backgroundMusic	= GameObject.FindGameObjectWithTag ("backgroundMusic").GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
