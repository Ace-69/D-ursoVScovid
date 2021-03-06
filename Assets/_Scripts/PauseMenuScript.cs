using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour {

    public static bool IsPaused = false;
    
    public GameObject pauseMenu;

    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape))
            if(IsPaused)
                Resume();
            else 
                Pause();
    }

    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }

    void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }
}
