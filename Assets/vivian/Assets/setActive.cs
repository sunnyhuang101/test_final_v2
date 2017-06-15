using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActive : MonoBehaviour {
	public GameObject panel_clicked;

	public void Active_panel(){
		if (!panel_clicked.activeInHierarchy) {
			panel_clicked.SetActive (true);	
		} else {
			panel_clicked.SetActive (false);
		}
	}
}
