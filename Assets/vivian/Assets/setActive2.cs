using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActive2 : MonoBehaviour {
	public GameObject panel_clicked2;

	public void Active_panel(){
		if (!panel_clicked2.activeInHierarchy) {
			panel_clicked2.SetActive (true);	
		} else {
			panel_clicked2.SetActive (false);
		}
	}
}
