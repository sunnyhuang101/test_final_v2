﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tingController : MonoBehaviour {


	public float speed = 1500f;
	public float rotationSpeed = 15f;

	public WheelJoint2D backWheel;
	public WheelJoint2D frontWheel;

	public Rigidbody2D rb;

	private float movement = 0f;
	private float rotation = 0f;

	//public GameObject backpack;//子彈預設物
	public Transform fire;//宣告一個變形對應到發射位置
	public appleController apple;
	public List <appleController> apple_list;

	private float x = 0.29f;//size of the backpack
	private float y = 0.30f;
	private float z = 1.17f;

	public AudioSource throw_sound;
	public AudioSource jump_sound;


	public float jumpSpeed = 50000f;

	//tingting
	JointMotor2D motorFront;

	JointMotor2D motorBack;


	public float speedF;
	public float speedB;


	public float torqueF;
	public float torqueB;


	public bool TractionFront = true;
	public bool TractionBack = true;


	public float carRotationSpeed;

	public float moveSpeed = 5000f;
	public GameObject grandma;
	public GameObject mama;
	public GameObject taxi;
	public GameObject taxi2;
	public GameObject changeScene;

	public GameObject car;
	void Start()
	{
		apple_list = new List<appleController> ();
		throw_sound = GameObject.FindGameObjectWithTag ("throwing").GetComponent<AudioSource> ();
		jump_sound = GameObject.FindGameObjectWithTag ("jumping").GetComponent<AudioSource> ();
	}

	void Update ()
	{
		//movement = -Input.GetAxisRaw("Vertical") * speed;
		//rotation = Input.GetAxisRaw("Horizontal");

		if (Input.GetAxisRaw ("Vertical") > 0) {


			if (TractionFront) {
				motorFront.motorSpeed = speedF * -1;
				motorFront.maxMotorTorque = torqueF;
				frontWheel.motor = motorFront;

			}

			if (TractionBack) {
				motorBack.motorSpeed = speedF * -1;
				motorBack.maxMotorTorque = torqueF;
				backWheel.motor = motorBack;

			}

		} else if (Input.GetAxisRaw ("Vertical") < 0) {


			if (TractionFront) {
				motorFront.motorSpeed = speedB * -1;
				motorFront.maxMotorTorque = torqueB;
				frontWheel.motor = motorFront;
			}

			if (TractionBack) {
				motorBack.motorSpeed = speedB * -1;
				motorBack.maxMotorTorque = torqueB;
				backWheel.motor = motorBack;

			}

		} else {

			backWheel.useMotor = false;
			frontWheel.useMotor = false;

		}




		if (Input.GetAxisRaw ("Horizontal") != 0) {

			GetComponent<Rigidbody2D> ().AddTorque (carRotationSpeed * Input.GetAxisRaw ("Horizontal") * -1);

		}

		if (Input.GetKeyDown(KeyCode.Z)){
			GetComponent<Rigidbody2D>().AddForce(new Vector2( 0,jumpSpeed));
			Debug.Log ("jump");
			jump_sound.Play ();

		}
		if (Input.GetMouseButtonDown(0) ) {
			var obj = Instantiate(apple,car.transform.position+ new Vector3(3, 2,0), car.transform.rotation);
			obj.transform.localScale = new Vector3(x, y, z);
			apple_list.Add (obj);
			throw_sound.Play ();
		}

		if (Vector2.Distance (this.gameObject.transform.position, grandma.transform.position) <= 20) {
			grandma.SetActive (true);
		}

		if (Vector2.Distance (this.gameObject.transform.position, mama.transform.position) <= 100) {
			mama.SetActive (true);
		}

		if (Vector2.Distance (this.gameObject.transform.position, taxi.transform.position) <= 150) {
			taxi.SetActive (true);
		}

		if (Vector2.Distance (this.gameObject.transform.position, taxi2.transform.position) <= 150) {
			taxi2.SetActive (true);
		}




		if (Vector2.Distance (this.gameObject.transform.position, changeScene.transform.position) <= 500) {
			Debug.Log ("enter");
			Application.LoadLevel("levelFinish");
		}
	}

}
