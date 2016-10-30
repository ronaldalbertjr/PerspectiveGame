using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditsBackToMenu : MonoBehaviour 
{
    [SerializeField]Canvas loadingPanel;
    void Start()
    {
        loadingPanel.enabled = false;
    }
	public void MenuButton()
	{
        StartCoroutine(LoadSceneWithLoadingScreen("Menu"));
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
