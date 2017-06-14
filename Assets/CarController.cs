using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CarController : MonoBehaviour {

	public float speed = 1500f;
	public float rotationSpeed = 15f;

	public WheelJoint2D backWheel;
	public WheelJoint2D frontWheel;

	public Rigidbody2D rb;

	private float movement = 0f;
	private float rotation = 0f;

	//public GameObject backpack;//子彈預設物
	public Transform fire;//宣告一個變形對應到發射位置
	public backpackController backpack;
	public List <backpackController> backpack_list;

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
	public GameObject eight;
	public GameObject bird;
	public GameObject taxi;
	public GameObject taxi2;


	void Start()
	{
		backpack_list = new List<backpackController> ();
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
			var obj = Instantiate(backpack, fire.position, fire.rotation);
			obj.transform.localScale = new Vector3(x, y, z);
			backpack_list.Add (obj);
			throw_sound.Play ();
		}

		if (Vector2.Distance (this.gameObject.transform.position, eight.transform.position) <= 150) {
			eight.SetActive (true);
		}

		if (Vector2.Distance (this.gameObject.transform.position, bird.transform.position) <= 100) {
			bird.SetActive (true);
		}

		if (Vector2.Distance (this.gameObject.transform.position, taxi.transform.position) <= 150) {
			taxi.SetActive (true);
		}

		if (Vector2.Distance (this.gameObject.transform.position, taxi2.transform.position) <= 150) {
			taxi2.SetActive (true);
		}
	}

	void FixedUpdate ()
	{/*
		if (movement == 0f)
		{
			backWheel.useMotor = false;
			frontWheel.useMotor = false;
		} else
		{
			backWheel.useMotor = true;
			frontWheel.useMotor = true;

			JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000 };
			backWheel.motor = motor;
			frontWheel.motor = motor;
		}

		if (Input.GetMouseButtonDown(0) ) {
			var obj = Instantiate(backpack, fire.position, fire.rotation);
			obj.transform.localScale = new Vector3(x, y, z);
			backpack_list.Add (obj);
			throw_sound.Play ();
		}

		if (Input.GetKeyDown(KeyCode.Z)){
			GetComponent<Rigidbody2D>().AddForce(new Vector2( 0,jumpSpeed));
			Debug.Log ("jump");

		}
		rb.AddTorque(-rotation * rotationSpeed * Time.fixedDeltaTime);

*/
    }

}
