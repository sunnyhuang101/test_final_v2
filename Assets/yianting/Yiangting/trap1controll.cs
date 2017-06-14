using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap1controll : MonoBehaviour {
    public Rigidbody2D car;
    public Transform carPos;
    Transform trap;
    public int magicnum;
	// Use this for initialization
	void Start () {
        trap = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        float dist;
        dist = carPos.position.y - trap.position.y;
        if(dist<5 && carPos.position.x >= trap.position.x-2.5 && carPos.position.x <= trap.position.x + 2.5)
            car.AddForce(new Vector2(0, magicnum / dist ));
    }
}
