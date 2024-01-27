using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public string titleScene = "Title";


    public void ToTitle()
    {
        SceneManager.LoadScene(titleScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
