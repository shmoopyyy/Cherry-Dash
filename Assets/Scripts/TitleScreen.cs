using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public string levelOne = "Level1";

    public void BeginGame()
    {
        SceneManager.LoadScene(levelOne);
    }
}
