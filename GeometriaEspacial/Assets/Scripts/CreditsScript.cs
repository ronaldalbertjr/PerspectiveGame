using UnityEngine;
using System.Collections;

public class CreditsScript : MonoBehaviour 
{
	Vector2 startTouchPosition, endTouchPosition, difference;
	void Start () 
    {
	
	}
	void Update () 
    {
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) 
		{
			startTouchPosition = Input.GetTouch(0).position;
		}
        else if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) 
		{
			endTouchPosition = Input.GetTouch(0).position;
			difference = endTouchPosition - startTouchPosition;
			this.transform.eulerAngles += new Vector3(0f, -(difference.x * Time.deltaTime) , (difference.y * Time.deltaTime)); 
		}
	}
}