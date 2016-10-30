using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour 
{
    Canvas loadingPanel;
    void Start()
    {
        loadingPanel = GameObject.Find("LoadingCanvas").GetComponent<Canvas>();
    }
    public void OnCollisionEnter(Collision col)
    {	
		if(col.gameObject.name == "Char")
        {
            switch(SceneManager.GetActiveScene().name)
            {
                case "Cena1":
                    PlayerPrefs.SetString("Level1", "1");
                    break;
                case "Cena2":
                    PlayerPrefs.SetString("Level2", "1");
                    break;
                case "Cena3":
                    PlayerPrefs.SetString("Level3", "1");
                    break;
                case "Cena4":
                    PlayerPrefs.SetString("Level4", "1");
                    break;
            }
            StartCoroutine(LoadSceneWithLoadingScreen(SceneManager.GetActiveScene().buildIndex + 1));
        }
    }
    IEnumerator LoadSceneWithLoadingScreen(int sceneInteger)
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(sceneInteger);
        async.allowSceneActivation = true;
        while (!async.isDone)
        {
            loadingPanel.enabled = true;
            loadingPanel.GetComponentInChildren<Text>().color = new Color(loadingPanel.GetComponentInChildren<Text>().color.r, loadingPanel.GetComponentInChildren<Text>().color.g, loadingPanel.GetComponentInChildren<Text>().color.b, Mathf.PingPong(Time.time, 1));
            yield return null;
        }
    }

}
