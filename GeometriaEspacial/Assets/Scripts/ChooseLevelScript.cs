using UnityEngine;
using System.Collections;

public class ChooseLevelScript : MonoBehaviour
{
    [SerializeField]
    GameObject[] formas;
    [SerializeField]
    Transform[] formasTransform;
	void Awake ()
    {
	    if(PlayerPrefs.HasKey("Level1"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Forma1Locked"));
            Instantiate(formas[0], formasTransform[0].position, formasTransform[0].rotation);
        }
        if(PlayerPrefs.HasKey("Level2"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Forma2Locked"));
            Instantiate(formas[1], formasTransform[1].position, formasTransform[1].rotation);
        }
        if (PlayerPrefs.HasKey("Level3"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Forma3Locked"));
            Instantiate(formas[2], formasTransform[2].position, formasTransform[2].rotation);
        }
        if (PlayerPrefs.HasKey("Level4"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Forma4Locked"));
            Instantiate(formas[3], formasTransform[3].position, formasTransform[3].rotation);
        }
    }
}
