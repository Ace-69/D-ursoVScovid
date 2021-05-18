using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {
    void Start() {
        Debug.Log("cose");
    }

    public void EndGame() {
        Time.timeScale = 1f;
        PauseMenuScript.IsPaused = false;
        SceneManager.LoadScene("Scenes/GameLost");
        Debug.Log("Game Over");
    }
    
    public void StartGame() {
        Time.timeScale = 1f;
        PauseMenuScript.IsPaused = false;
        SceneManager.LoadScene("Scenes/Game");
        Debug.Log("Game Started");
    }

    public void MainMenu() {
        Time.timeScale = 1f;
        PauseMenuScript.IsPaused = false;
        SceneManager.LoadScene("Scenes/MainMenu");
        Debug.Log("Main Menu");
    }

    public void Quit(){
        Application.Quit();
    }
}
