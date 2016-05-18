using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraBehaviour : MonoBehaviour 
{
    public Text view;
    bool right, left, up, front, back = false;
	bool rightSwipe, leftSwipe,upSwipe, downSwipe = false;
	Vector2 firstPressPos;
	Vector2 secondPressPos;
	Vector2 currentSwipe;
	Touch t;
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
            if (upSwipe)
            {
                UpVision();
				upSwipe = false;
            }
			else if (leftSwipe)
            {
                LeftVision();
				leftSwipe = false;
            }
			else if (rightSwipe)
            {
                RightVision();
				rightSwipe = false;
            }
        }
        else if (up)
        {
            view.text = "Up";
            this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(-4f, 13f, 12f), 0.5f);
            this.transform.eulerAngles = Vector3.Lerp(this.transform.eulerAngles, new Vector3(90f, 270f, 0f), 0.5f);
			if (downSwipe)
            {
                FrontVision();
				downSwipe = false;
            }
			else if (upSwipe)
            {
                BackVision();
				upSwipe = false;
            }
			else if (leftSwipe)
            {
                LeftVision();
				leftSwipe = false;
            }
			else if (rightSwipe)
            {
                RightVision();
				rightSwipe = false;
            }
        }
        else if (back)
        {
            view.text = "Back";
            this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(-16f, 5f, 12f), 0.5f);
            this.transform.eulerAngles = Vector3.Lerp(this.transform.eulerAngles, new Vector3(0f, 90f, 0f), 0.5f);
			if (downSwipe)
            {
                UpVision();
				upSwipe = false;
            }
			else if (leftSwipe)
            {
                RightVision();
				leftSwipe = false;
            }
			else if (rightSwipe)
            {
                LeftVision();
				rightSwipe = false;
            }
        }
        else if (left)
        {
            view.text = "Left";
            this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(-5f, 2.5f, -10f), 0.5f);
            this.transform.eulerAngles = Vector3.Lerp(this.transform.eulerAngles, new Vector3(0f, 0f, 0f), 0.5f);
			if (upSwipe)
            {
                UpVision();
				upSwipe = false;
            }
			else if (rightSwipe)
            {
                BackVision();
				rightSwipe = false;
            }
			else if (leftSwipe)
            {
                FrontVision();
				leftSwipe = false;
            }
        }
        else if (right)
        {
            view.text = "Right";
            this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(-5f, 2.5f, 30f), 0.5f);
            this.transform.eulerAngles = Vector3.Lerp(this.transform.eulerAngles, new Vector3(0f, 180f, 0f), 0.5f);
			if (upSwipe)
            {
                UpVision();
				upSwipe = false;
            }
			else if (rightSwipe)
            {
                FrontVision();
				rightSwipe = false;
            }
			else if (leftSwipe)
            {
                BackVision();
				leftSwipe = false;
            }
        }
    }
	void Swipe()
	{
		if(Input.touches.Length > 0)
		{
			t = Input.GetTouch(0);
			if(t.phase == TouchPhase.Began)
			{
				firstPressPos = new Vector2(t.position.x,t.position.y);
			}
			if(t.phase == TouchPhase.Ended)
			{
				secondPressPos = new Vector2(t.position.x,t.position.y);
				currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);
				currentSwipe.Normalize();
				if(currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
				{
					upSwipe = true;
					leftSwipe = false;
					rightSwipe = false;
					downSwipe = false;
				}
				else if(currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
				{
					downSwipe = true;
					leftSwipe = false;
					rightSwipe = false;
					upSwipe = false;
				}
				else if(currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
				{
					leftSwipe = true;
					rightSwipe = false;
					upSwipe = false;
					downSwipe = false;
				}
				if(currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
				{
					rightSwipe = true;
					leftSwipe = false;
					upSwipe = false;
					downSwipe = false;
				}
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
