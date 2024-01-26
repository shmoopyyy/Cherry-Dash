using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
  public string titleScene = "Title";
 

  public void ToTitle()
  {
    // GM.resetGame();   // implement this
    SceneManager.LoadScene(titleScene);
  }
}