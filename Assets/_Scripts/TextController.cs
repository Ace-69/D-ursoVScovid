using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour {
    public static int Lives = 3;
    public static int points = 0;
    public static int Level = 1;
    public static float enemyhp = 100f;
    public static float ATK = 50f;
    public static float FireRate = 0.5f;
    public static int nextLevelPoints = 100;
    Text text;
    void Start() {
        text = GetComponent<Text>();
    }
    void Update() {
        if(FireRate < 0) FireRate = 0;
        if(Lives <= 0) {
            SceneManager.LoadScene("Scenes/GameLost");
        }
        if(points >= nextLevelPoints){
            nextLevelPoints *= 2;
            enemyhp += (float)((int)(enemyhp/2));
            Level ++;
        }
        text.text = "Vite: " + Lives +"\nPunti: " + points + "\nHP nemici: " + enemyhp+ "\nATK: " + ATK + "\nBPS: " + FireRate + "\nLivello: " + Level;
        
    }
}
