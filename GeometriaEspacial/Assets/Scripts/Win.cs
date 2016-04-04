using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour 
{
    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Char")
        {
            Application.LoadLevel(Application.loadedLevel + 1);
        }
    }

}
