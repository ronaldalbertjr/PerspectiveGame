using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChooseLevelRotatingScript : MonoBehaviour
{
    [SerializeField]
    string lockedTag;
    [SerializeField]
    string trueTag;
    GameObject forma;
    void Start()
    {
        forma = GameObject.FindGameObjectWithTag(lockedTag);
    }
  	void Update ()
    {
        if(forma == null)
        {
            forma = GameObject.FindGameObjectWithTag(trueTag);
        }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            if (hit.collider.name == this.gameObject.name)
            {
                forma.transform.eulerAngles += new Vector3(0, 20f * Time.deltaTime, 0);
                if(Input.GetMouseButton(0))
                {
                    switch(hit.collider.name)
                    {
                        case "Forma1Move":
                            if (PlayerPrefs.HasKey("Level1"))
                            {
                                SceneManager.LoadScene("Cena1");
                            }
                            break;
                        case "Forma2Move":
                            if (PlayerPrefs.HasKey("Level2"))
                            {
                                SceneManager.LoadScene("Cena2");
                            }
                            break;
                        case "Forma3Move":
                            if (PlayerPrefs.HasKey("Level3"))
                            {
                                SceneManager.LoadScene("Cena3");
                            }
                            break;
                        case "Forma4Move":
                            if (PlayerPrefs.HasKey("Level4"))
                            {
                                SceneManager.LoadScene("Cena4");
                            }
                            break;

                    }
                }
            }
        }    	
	}
}
