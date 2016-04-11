using UnityEngine;
using System.Collections;

public class CreditsScript : MonoBehaviour 
{
    float h;
    float v;
	void Start () 
    {
	
	}
	void Update () 
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        this.transform.eulerAngles += new Vector3(0f, -h, -v);
	}
}
