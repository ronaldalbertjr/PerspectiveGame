using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraBehaviour : MonoBehaviour 
{
    public Text view;
    bool right, left, up, front, back = false;
    void Start () 
    {
        front = true;
	}
	void Update () 
    {
        if (front)
        {
            view.text = "Front";
            this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(9f, 5f, 12f), 0.5f);
            this.transform.eulerAngles = Vector3.Lerp(this.transform.eulerAngles, new Vector3(0f, 270f, 0f), 0.5f);
            if (Input.GetKeyUp(KeyCode.W))
            {
                UpVision();
            }
            else if (Input.GetKeyUp(KeyCode.A))
            {
                LeftVision();
            }
            else if (Input.GetKeyUp(KeyCode.D))
            {
                RightVision();
            }
        }
        else if (up)
        {
            view.text = "Up";
            this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(-4f, 13f, 12f), 0.5f);
            this.transform.eulerAngles = Vector3.Lerp(this.transform.eulerAngles, new Vector3(90f, 270f, 0f), 0.5f);
            if (Input.GetKeyUp(KeyCode.S))
            {
                FrontVision();
            }
            else if (Input.GetKeyUp(KeyCode.W))
            {
                BackVision();
            }
            else if (Input.GetKeyUp(KeyCode.A))
            {
                LeftVision();
            }
            else if (Input.GetKey(KeyCode.D))
            {
                RightVision();
            }
        }
        else if (back)
        {
            view.text = "Back";
            this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(-16f, 5f, 12f), 0.5f);
            this.transform.eulerAngles = Vector3.Lerp(this.transform.eulerAngles, new Vector3(0f, 90f, 0f), 0.5f);
            if (Input.GetKeyUp(KeyCode.W))
            {
                UpVision();
            }
            else if (Input.GetKeyUp(KeyCode.A))
            {
                RightVision();
            }
            else if (Input.GetKeyUp(KeyCode.D))
            {
                LeftVision();
            }
        }
        else if (left)
        {
            view.text = "Left";
            this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(-5f, 2.5f, -10f), 0.5f);
            this.transform.eulerAngles = Vector3.Lerp(this.transform.eulerAngles, new Vector3(0f, 0f, 0f), 0.5f);
            if (Input.GetKeyUp(KeyCode.W))
            {
                UpVision();
            }
            else if (Input.GetKeyUp(KeyCode.A))
            {
                BackVision();
            }
            else if (Input.GetKeyUp(KeyCode.D))
            {
                FrontVision();
            }
        }
        else if (right)
        {
            view.text = "Right";
            this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(-5f, 2.5f, 30f), 0.5f);
            this.transform.eulerAngles = Vector3.Lerp(this.transform.eulerAngles, new Vector3(0f, 180f, 0f), 0.5f);
            if (Input.GetKeyUp(KeyCode.W))
            {
                UpVision();
            }
            else if (Input.GetKeyUp(KeyCode.A))
            {
                FrontVision();
            }
            else if (Input.GetKeyUp(KeyCode.D))
            {
                BackVision();
            }
        }
    }
    void FrontVision()
    {
        front = true;
        left = false;
        back = false;
        right = false;
        up = false;
    }
    void UpVision()
    {
        up = true;
        left = false;
        back = false;
        right = false;
        front = false;
    }
    void BackVision()
    {
        back = true;
        left = false;
        up = false;
        right = false;
        front = false;
    }
    void LeftVision()
    {
        left = true;
        back = false;
        up = false;
        right = false;
        front = false;
    }
    void RightVision()
    {
        right = true;
        back = false;
        up = false;
        left = false;
        front = false;
    }
}
