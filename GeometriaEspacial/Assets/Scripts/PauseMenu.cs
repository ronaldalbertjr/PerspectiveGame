using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public Slider slider;
    public Canvas menu;
    public Canvas erase;
    public Canvas loadingPanel;
    public AudioSource mainAudio;
    void Start()
    {
        menu.enabled = false;
        loadingPanel.enabled = false;
        slider.value = mainAudio.volume;
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
        StartCoroutine(LoadSceneWithLoadingScreen("Menu"));
        Time.timeScale = 1;
    }
    public void OnSlide()
    {
        mainAudio.volume = slider.value;
    }

    IEnumerator LoadSceneWithLoadingScreen(string sceneString)
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(sceneString);
        async.allowSceneActivation = true;
        while (!async.isDone)
        {
            loadingPanel.enabled = true;
            loadingPanel.GetComponentInChildren<Text>().color = new Color(loadingPanel.GetComponentInChildren<Text>().color.r, loadingPanel.GetComponentInChildren<Text>().color.g, loadingPanel.GetComponentInChildren<Text>().color.b, Mathf.PingPong(Time.time, 1));
            yield return null;
        }
    }
}
