using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringControl : MonoBehaviour {
    public Rigidbody2D car;
    public Collider2D carCollider;
    Collider2D spring;
    public float Addforce; 
	// Use this for initialization
	void Start () {
        spring = GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (spring.IsTouching (carCollider)) {
			car.AddForce(new Vector2(Addforce, 0));
			Debug.Log("wqwqqwrq");
		}
            
	}
}
