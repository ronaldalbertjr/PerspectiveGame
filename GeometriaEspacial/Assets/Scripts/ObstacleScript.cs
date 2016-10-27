using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour 
{
    void OnTriggerStay(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<CharacterBehaviour>().canGoUp = true;
        }
    }
}
