using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public AudioSource levelMusic;
    public GameObject pauseMenu;
    public AudioSource pause;
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (gamePaused == false)
            {
                pause.Play();
                pauseMenu.SetActive(true);
                levelMusic.Pause();
                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;
            }
            else
            {
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;
                levelMusic.UnPause();
                pauseMenu.SetActive(false);
            }
        }
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        
    }
    public void RestartLevel()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
    public void QuitToMenu()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = true;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
