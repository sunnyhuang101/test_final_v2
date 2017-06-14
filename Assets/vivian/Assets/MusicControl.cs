using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour {
	private AudioSource audio;
	private bool muteState;
	private float preVolume;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
		audio.volume = 0;
		muteState = false;
		preVolume = audio.volume;
	}

	public void VolumeChange(float newVolume) {
		audio.volume = newVolume;
		muteState = false;
	}

	public void MuteClick() {
		muteState = !muteState;
		if (muteState) {
			preVolume = audio.volume;
			audio.volume = 0;
		} else
			audio.volume = preVolume;
	}
	// Update is called once per frame
	/*void Update () {
		
	}*/
}
