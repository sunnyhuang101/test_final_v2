using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class backpackController : MonoBehaviour {

	public float speed = 30f;
	public bool isColli = false;

	private float x = 5f;
	private int hit = 0;
	private Collider2D target;
	public SpriteRenderer target_s;
	private float alph = 1;
	private float alph_b = 1;

	private float time_f = 0;

	public AudioSource bird_sound, eight_sound, taxi_sound;

	private int count = 0;

	// Use this for initialization
	void Start () {
		//GetComponent<Rigidbody2D> ().AddForce(transform.right * speed);
		bird_sound = GameObject.FindGameObjectWithTag ("bird_sound").GetComponent<AudioSource> ();
		eight_sound = GameObject.FindGameObjectWithTag ("eight_sound").GetComponent<AudioSource> ();
		taxi_sound = GameObject.FindGameObjectWithTag ("taxi_sound").GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().AddForce(transform.right * speed);
		if (Input.GetMouseButton(0)){
			Debug.Log("keep");
		}
		if (hit == 1 && alph == 1) {
			target_s = target.gameObject.GetComponent<SpriteRenderer> ();
			alph = alph - 0.01f;
		
		} else if (hit == 1 && alph >= 0 && alph <= 1) {//擊中後，enemy和包包漸漸消失
			alph = alph - 0.01f;
			this.gameObject.GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, alph);
			target_s.material.color = new Color (1, 1, 1, alph);//new color (紅, 綠, 藍, 透明) 
			//紅=1 綠=1 藍=1 ＝> 保持原來色調 透明=1 =>無透明 透明=0 =>無透明
		} else if (alph < 0) {
			hit = 0;
			alph = 1;

			//target.gameObject.SetActive (false);
			Destroy(target);
			this.gameObject.SetActive (false);
			Debug.Log (target.gameObject.GetComponent<SpriteRenderer> ().name);



		}





		//else if ((this.gameObject.transform.position.x > 500) && (alph_b >= 0) && hit==0 ) {
			//alph = alph - 0.01f;
			//this.gameObject.GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, alph);
		//} else if ((alph_b < 0)&&(this.gameObject.transform.position.x > 500) &&  hit==0) {
			//this.gameObject.SetActive (false);
	//	}

		//if ((this.gameObject.transform.position.x > 50) && hit ==0) {
			//this.gameObject.SetActive (false);
		//}

		//if ( hit == 0 &&(Time.time > nextrate)) {
		//	this.gameObject.GetComponent<SpriteRenderer>().color = new Color (1, 1, 1, alph_b);
		//	alph_b = alph_b - 0.01f;
		//}

		//if (alph_b < 0) {
		//	nextrate = Time.time + rate;
		//	this.gameObject.SetActive (false);

		//}

	}

	//void OnCollisionEnter(Collision other)
	//{	
	//	Debug.Log ("Hi");
	//}


	void OnTriggerEnter2D(Collider2D t){
		if (t.tag == "enemy") 
		{
			//target.gameObject.SetActive (false);
			hit = 1; //是否擊中enemy
			target = t;
			if ((target.gameObject.GetComponent<SpriteRenderer> ().name == "taxi") 
				||	(target.gameObject.GetComponent<SpriteRenderer> ().name == "taxi2")
				)
			{
				taxi_sound.Play ();

			}
			if (target.gameObject.GetComponent<Animator> ().name == "eight_0") {
				eight_sound.Play ();
				Debug.Log ("taxi");
			}
			if (target.gameObject.GetComponent<Animator> ().name == "bird_0") {
				bird_sound.Play ();
			}
		}
	
	}


}
