using UnityEngine;
using System.Collections;

public class CharacterBehaviour : MonoBehaviour 
{
    public Vector3 aux;
    bool alreadystarted = false;
    Vector3 newposition;
    Vector3 newrotation;
    Quaternion qr;
    float moveh;
    float movev;
    bool movinh;
    bool movinv;
    void Start ()
    {
    }
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
            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (this.transform.eulerAngles.x == 90 || this.transform.eulerAngles.x == 270)
                {
                    this.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                }
                if (this.transform.position == newposition || alreadystarted == false)
                {
                    newposition = this.transform.position + Vector3.left;
                    newrotation = this.transform.eulerAngles + new Vector3(0f, 0f, 90f);
                }
                alreadystarted = true;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                if (this.transform.eulerAngles.x == 90 || this.transform.eulerAngles.x == 270)
                {
                    this.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                }
                if (this.transform.position == newposition || alreadystarted == false)
                {
                    newposition = this.transform.position + Vector3.right;
                    newrotation = this.transform.eulerAngles + new Vector3(0f, 0f, -90f);
                }
                alreadystarted = true;
            }
        }
        if (movinh)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (this.transform.position == newposition || alreadystarted == false)
                {
                    newposition = this.transform.position + Vector3.forward;
                    newrotation = this.transform.eulerAngles + new Vector3(90f, 0f, 0f);
                }
                alreadystarted = true;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.transform.position == newposition || alreadystarted == false)
                {
                    newposition = this.transform.position + Vector3.back;
                    newrotation = this.transform.eulerAngles + new Vector3(-90f, 0f, 0f);
                }
                alreadystarted = true;
            }
        }
         qr = Quaternion.Euler(newrotation);
        if (alreadystarted)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, newposition, 0.7f);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, qr, 0.7f);
        }
   }
}
