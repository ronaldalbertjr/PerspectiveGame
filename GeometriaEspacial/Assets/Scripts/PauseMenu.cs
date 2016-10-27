using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Slider slider;
    public Canvas menu;
    public Canvas erase;
    public AudioSource audio;
    void Start()
    {
        menu.enabled = false;
        slider.value = audio.volume;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            menu.enabled = true;
            erase.enabled = false; 
            Time.timeScale = 0;
        }
    }
    public void OnResume()
    {
        menu.enabled = false;
        erase.enabled = true;
        Time.timeScale = 1;
    }
    public void OnBackToMenu()
    {
        Application.LoadLevel("Menu");
        Time.timeScale = 1;
    }
    public void OnSlide()
    {
        audio.volume = slider.value;
    }
}
