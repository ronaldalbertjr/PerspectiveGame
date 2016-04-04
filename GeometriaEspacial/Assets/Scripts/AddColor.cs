using UnityEngine;
using System.Collections;

public class AddColor : MonoBehaviour 
{
    public Color c;
    void Start()
    {
        this.GetComponent<Renderer>().material.color = c;
    }
    void Update()
    {

    }
}
