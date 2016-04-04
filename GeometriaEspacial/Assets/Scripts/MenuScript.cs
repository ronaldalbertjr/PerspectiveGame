using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour
{
    public Canvas Menu;
    public Canvas Exit;
    void Start ()
    {
        Exit.enabled = false;
	}
    public void PlayPressed()
    {
        Application.LoadLevel("Cena1");
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
}
