using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_menu : MonoBehaviour
{
    
    public GameObject _pausemenu;
    void PauseGame()
    {
        Time.timeScale = 0;
    }
    void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public static bool gameIsPaused;
    private void Start()
    {
        gameIsPaused = false;
        Time.timeScale = 1;
        _pausemenu.SetActive(false);
        AudioListener.pause = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
            PauseGamer();
        }
    }
    void PauseGamer()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
            _pausemenu.SetActive(true);
            AudioListener.pause = true;
        }
        else
        {
            Time.timeScale = 1;
            _pausemenu.SetActive(false);
            AudioListener.pause = false;
        }
    }
}

