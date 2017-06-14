using System.Collections;
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
                component_rigid.velocity = new Vector2((float)(90.78 - 92.17) / 5, 0);
            }
            else
            {
                component_rigid.velocity = new Vector2((float)(90.78- 92.17)/5, (float)(-1.27 + 2.3)/5);
            }
            if (elev_trans.position.x >= component.position.x )
                component.position= new Vector3((float)93.46, (float)-3.02);
        }
        else
        {
            if (elev_trans.position.y <= component.position.y)
            {
                component_rigid.velocity = new Vector2((float)(-90.78 + 92.17) / 5, 0);
            }
            else
            {
                component_rigid.velocity = new Vector2((float)(27.76 - 26.37) / 5, (float)(0.31 + 0.71) / 5);
            }
            if (elev_trans.position.x <= component.position.x)
                component.position = new Vector3((float)(108.26), (float)-2.95);
        }
		

    }
}
