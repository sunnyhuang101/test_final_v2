using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taxi_controller : MonoBehaviour {

	public SpriteRenderer taxi_s, taxif_s, taxiw_s;//fade
	//public GameObject frontwheel;
	//public GameObject backwheel;
	private float alph = 0.99f;
    public int speed;
	//private float alph = 1;

	// Use this for initialization
	void Start () {
		this.gameObject.SetActive (false);
		taxi_s = this.gameObject.GetComponent<SpriteRenderer> ();
		//taxif_s = frontwheel.gameObject.GetComponent<SpriteRenderer> ();
		//taxiw_s = backwheel.gameObject.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (new Vector2 (-speed, 0) * Time.deltaTime);
	//	alph = alph - 0.01f;

		//if (taxif_s.material.color.a <= 0) {
		//	Destroy (taxif_s);
		//	Destroy (taxiw_s);
		//}
		if (taxi_s.material.color.a < 1) 
		{
			//	taxif_s.material.color =  new Color (1, 1, 1,alph);
			//	taxiw_s.material.color =  new Color (1, 1, 1,alph);
			alph = alph - 0.01f;//若是計程車被擊中，輪子也要消失
		}

	//		boss.material.color =  new Color (1, 1, 1,alph);
	
			

	}
}
