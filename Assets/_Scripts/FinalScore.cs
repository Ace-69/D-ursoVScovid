using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    Text text;
    void Start() {
        text = GetComponent<Text>();
        text.text = "Il tuo Punteggio:\nPunti: " + TextController.points + "   Livello: " + TextController.Level + "\nATK: " + TextController.ATK + "    BPS: " + TextController.FireRate + "\nHP nemici: " + TextController.enemyhp;
        TextController.Lives = 3;
        TextController.points = 0;
        TextController.Level = 1;
        TextController.enemyhp = 100f;
        TextController.ATK = 50f;
        TextController.FireRate = 0.5f;
        TextController.nextLevelPoints = 100;
    }
}
