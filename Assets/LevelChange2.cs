using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChange2 : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Application.LoadLevel("carscene2");
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
