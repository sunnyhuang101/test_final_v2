using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyController : MonoBehaviour {

	public GameObject backpack;//子彈預設物
	public Transform fire;//宣告一個變形對應到發射位置
	public backpackController b;
	public List <backpackController> objlist;



	private float x = 0.29f;
	private float y = 0.30f;
	private float z = 1.17f;
	// Use this for initialization
	void Start () {
		//backpack.SetActive(false);
		objlist = new List<backpackController> ();
	}

	// Update is called once per frame
	void Update () {
		

		if (Input.GetMouseButtonDown(0) ) {
			//Instantiate (backpack, fire.position, fire.rotation);
			var obj = Instantiate(b, fire.position, fire.rotation);
			obj.transform.localScale = new Vector3(x, y, z);
			objlist.Add (obj);

		//	backpack.SetActive(true);
			//backpack.transform.position =fire.position;
			//backpack.transform.rotation =fire.rotation;
		}


			
	}
}
