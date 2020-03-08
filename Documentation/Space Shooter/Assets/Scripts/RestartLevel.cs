using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            //set the score back to zero upon retrying
            PlayerScore.playerScore = 0;
            //bring the player back to life upon retrying
            GameOver.isPlayerDead = false;
            Time.timeScale = 1;

            SceneManager.LoadScene("Scene001");
        }
    }
}
