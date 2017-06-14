using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChangePipe : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Application.LoadLevel("2");
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
