using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text; 
    int score;

    void Start()
    { 
        if (instance == null)
        {
            instance = this;
        }
    } 

    public void UpdateScore(int addend)
    {
        score += addend;
        text.text = "Score: " + score.ToString();
    }

}