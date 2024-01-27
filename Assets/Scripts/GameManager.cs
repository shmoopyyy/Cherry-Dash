using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string GameOver = "GameOver";
    public GameObject Player;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }   

    // Update is called once per frame
    void Update()
    {
        float playerY = Player.transform.position.y;

        if (playerY <= (-12))
        { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}