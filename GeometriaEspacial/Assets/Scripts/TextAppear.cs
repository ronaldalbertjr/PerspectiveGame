using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextAppear : MonoBehaviour 
{
    [SerializeField] Text txt;
    [SerializeField] string textToAppear;
    public void OnTriggerEnter()
    {
        txt.text = textToAppear;
    }
    public void OnTriggerExit()
    {
        txt.text = "";
    }
}
