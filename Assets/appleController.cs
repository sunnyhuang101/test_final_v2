using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleController : MonoBehaviour {



		public float speed = 30f;
		public bool isColli = false;

		private float x = 5f;
		private int hit = 0;
		private Collider2D target;
		public SpriteRenderer target_s;
		private float alph = 1;
		private float alph_b = 1;

		private float time_f = 0;

		public AudioSource mama_sound, grandma_sound, taxi_sound;

		private int count = 0;

		// Use this for initialization
		void Start () {
			//GetComponent<Rigidbody2D> ().AddForce(transform.right * speed);
			mama_sound = GameObject.FindGameObjectWithTag ("mama").GetComponent<AudioSource> ();
			grandma_sound = GameObject.FindGameObjectWithTag ("grandma").GetComponent<AudioSource> ();
			//taxi_sound = GameObject.FindGameObjectWithTag ("taxi_sound").GetComponent<AudioSource> ();

		}

		// Update is called once per frame
		void Update () {
		GetComponent<Rigidbody2D> ().AddForce (transform.right * speed);
		if (Input.GetMouseButton (0)) {
			Debug.Log ("keep");
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
			Destroy (target);
			this.gameObject.SetActive (false);
			Debug.Log (target.gameObject.GetComponent<SpriteRenderer> ().name);



		}



	}



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
				if (target.gameObject.GetComponent<Animator> ().name == "grandma_0") {
					grandma_sound.Play ();
					Debug.Log ("taxi");
				}
				if (target.gameObject.GetComponent<Animator> ().name == "mama_0") {
					mama_sound.Play ();
				}
			}

		}

	


}
