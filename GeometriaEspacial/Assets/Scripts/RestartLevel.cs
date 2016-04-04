using UnityEngine;
using System.Collections;

public class RestartLevel : MonoBehaviour 
{
	void Start ()
    {
	
	}
	void Update () 
    {
	
	}
    public void OnCollisionEnter(Collision col)
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
