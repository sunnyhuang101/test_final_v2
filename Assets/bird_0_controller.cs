using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_0_controller : MonoBehaviour {

	public Animator animator;
	public int r = 0;
	public GameObject target;
	public float speed = 0.5f;
	public float firstSpeed;

	// Use this for initialization

	void Start () {
		this.gameObject.SetActive (false);
		animator = GetComponent<Animator>();
		firstSpeed = Vector2.Distance(animator.transform.position, target.transform.position) * speed;
	}
	
	// Update is called once per frame
	void Update () {
		//animator.transform.position = Vector3.Lerp (animator.transform.position, target.transform.position, 1);
		//animator.transform.Translate(new Vector2 (-1, 0)*Time.deltaTime);


			//先移動過後，再計算新的 speed
		//animator.transform.position = Vector3.Lerp(animator.transform.position, target.transform.position, speed*Time.deltaTime);
			speed = calculateNewSpeed();
		this.transform.Translate(new Vector2 (-8, 0)*Time.deltaTime);

	}

	private float calculateNewSpeed()
	{
		//因為每次移動都是 Obj 在移動，所以要取得 Obj 和 PathB 的距離
		float tmp = Vector3.Distance(animator.transform.position, target.transform.position);

		//當距離為0的時候，就代表已經移動到目的地了。
		if (tmp == 0)
			return tmp;
		else
			return (firstSpeed / tmp);
	}

}
