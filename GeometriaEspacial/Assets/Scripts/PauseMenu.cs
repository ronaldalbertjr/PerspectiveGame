using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Slider slider;
    public Canvas menu;
    public Canvas erase;
    public AudioSource audio;
    GameObject character;
	void Start ()
    {
        menu.enabled = false;
        slider.value = audio.volume;
        character = GameObject.Find("Char");
	}
	void Update ()
    {
	    if(Input.GetKey(KeyCode.Escape))
        {
            menu.enabled = true;
            erase.enabled = false;
            character.transform.eulerAngles = character.GetComponent<CharacterBehaviour>().newrotation;
            character.transform.position = character.GetComponent<CharacterBehaviour>().newposition;
            Destroy(character.GetComponent<CharacterBehaviour>());
        }    
	}
    public void OnResume()
    {
        menu.enabled = false;
        erase.enabled = true;
        character.AddComponent<CharacterBehaviour>();
    }
    public void OnBackToMenu()
    {
        Application.LoadLevel("Menu");
    }
    public void OnSlide()
    {
        audio.volume = slider.value;
    }
}
