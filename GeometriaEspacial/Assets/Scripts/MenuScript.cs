using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public Canvas Menu;
    public Canvas Exit;
    public Canvas loadingPanel;
    void Start ()
    {
        Exit.enabled = false;
        loadingPanel.enabled = false;
	}
    public void PlayPressed()
    {
        StartCoroutine(LoadSceneWithLoadingScreen("Cena1"));
    }
    public void ChooseLevelPressed()
    {
        StartCoroutine(LoadSceneWithLoadingScreen("ChooseLevel"));
    }
    public void ExitPressed()
    {
        Exit.enabled = true;
        Menu.enabled = false;
    }
    public void YesPressed()
    {
        Application.Quit();
    }
    public void NoPressed()
    {
        Exit.enabled = false;
        Menu.enabled = true;
    }
    public void CreditsPressed()
    {
        StartCoroutine(LoadSceneWithLoadingScreen("Creditos"));
    }

    IEnumerator LoadSceneWithLoadingScreen(string sceneString)
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(sceneString);
        async.allowSceneActivation = true;
        while(!async.isDone)
        {
            loadingPanel.enabled = true;
            loadingPanel.GetComponentInChildren<Text>().color = new Color(loadingPanel.GetComponentInChildren<Text>().color.r, loadingPanel.GetComponentInChildren<Text>().color.g, loadingPanel.GetComponentInChildren<Text>().color.b, Mathf.PingPong(Time.time, 1));
            yield return null;
        }
    }
}
