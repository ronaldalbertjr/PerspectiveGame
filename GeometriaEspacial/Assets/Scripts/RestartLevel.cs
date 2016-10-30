using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour 
{
    public void OnCollisionEnter(Collision col)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
