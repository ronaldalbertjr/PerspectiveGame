using UnityEngine;
using System.Collections;

public class TextAppear : MonoBehaviour 
{
    public Canvas c;
	void Start ()
    {
        c.enabled = false;
	}
    public void OnCollisionEnter()
    {
        c.enabled = true;
    }
    public void OnCollisionExit()
    {
        c.enabled = false;
    }
}
