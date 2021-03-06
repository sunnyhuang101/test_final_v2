﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatecontroll : MonoBehaviour {
    public Transform elev_trans;
    public bool dir;
    Transform component;
    Rigidbody2D component_rigid;
	// Use this for initialization
	void Start () {
        component = GetComponent<Transform>();
        component_rigid = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!dir)
        {
            if(elev_trans.position.y<= component.position.y)
            {
                component_rigid.velocity = new Vector2((float)(90.78 - 92.17) / 2, 0);
            }
            else
            {
                component_rigid.velocity = new Vector2((float)(90.78- 92.17)/2, (float)(-1.27 + 2.3)/2);
            }
            if (elev_trans.position.x >= component.position.x )
                component.position= new Vector3((float)93.19, (float)-3.31);
        }
        else
        {
            if (elev_trans.position.y <= component.position.y)
            {
                component_rigid.velocity = new Vector2((float)(-90.78 + 92.17) / 2, 0);
            }
            else
            {
                component_rigid.velocity = new Vector2((float)(27.76 - 26.37) / 2, (float)(0.31 + 0.71) / 2);
            }
            if (elev_trans.position.x <= component.position.x)
                component.position = new Vector3((float)(108.26), (float)-2.95);
        }
		

    }
}
