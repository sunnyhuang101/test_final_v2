﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour {

	public	void ChangeToScene (string scene) {
		Application.LoadLevel (scene);
	}
}
