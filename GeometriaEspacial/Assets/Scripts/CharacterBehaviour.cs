﻿using UnityEngine;
using System.Collections;

public class CharacterBehaviour : MonoBehaviour 
{
    bool alreadystarted = false;
    public Vector3 newposition;
    public Vector3 newrotation;
    Quaternion qr;
    float moveh;
    float movev;
    bool movinh;
    bool movinv;
    int xl;
    int zl;
    void Update()
    {
        moveh = Input.GetAxis("Horizontal");
        movev = Input.GetAxis("Vertical");
        if (this.transform.position == newposition || alreadystarted == false)
        {
            movinh = (moveh != 0 || movev == 0);
            movinv = (!movinh);
        }
		newposition.y = this.transform.position.y;
        if (movinv) 
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).position.y < (Screen.height/2) - 200)
            {
                if (this.transform.eulerAngles.x == 90 || this.transform.eulerAngles.x == 270)
                {
                    newrotation.x = 0f;
                }
                if (this.transform.position == newposition || alreadystarted == false)
                {
                    newposition = this.transform.position + Vector3.left;
                    newrotation.z += 90f;
                }
                alreadystarted = true;
            }
            else if (Input.touchCount > 0 && Input.GetTouch(0).position.y > (Screen.height / 2) + 200)
            {
                if (this.transform.eulerAngles.x == 90 || this.transform.eulerAngles.x == 270)
                {
                    newrotation.x = 0f;
                }
                if (this.transform.position == newposition || alreadystarted == false)
                {
                    newposition = this.transform.position + Vector3.right;
                    newrotation.z -= 90f;
                }
                alreadystarted = true;
            }
        }
        if (movinh)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).position.y > (Screen.width / 2) + 200)
            {
                if (this.transform.eulerAngles.x == 90 || this.transform.eulerAngles.x == 270)
                {
                    newrotation.z = 0f;
                }
                if (this.transform.position == newposition || alreadystarted == false)
                {
                    newposition = this.transform.position + Vector3.forward;
                    newrotation.x += 90f;
                }
                alreadystarted = true;
            }
            else if (Input.touchCount > 0 && Input.GetTouch(0).position.y < (Screen.height / 2) - 200)
            {
                if (this.transform.eulerAngles.x == 90 || this.transform.eulerAngles.x == 270)
                {
                    newrotation.z = 0f;
                }
                if (this.transform.position == newposition || alreadystarted == false)
                {
                    newposition = this.transform.position + Vector3.back;
                    newrotation.x -= 90f;
                }
                alreadystarted = true;
            }
        }
         qr = Quaternion.Euler(newrotation);
        if (alreadystarted)
        {
            this.transform.position = Vector3.Slerp(this.transform.position, newposition, 0.5f);
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, qr, 0.5f);
        }
   }
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.transform.position.y == this.transform.position.y )
		{
			newposition += Vector3.up;
		}
	}
}
