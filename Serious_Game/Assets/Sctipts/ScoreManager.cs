using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] int scoreThresholdForThisLevel;
    public static ScoreManager instance;
    public TextMeshProUGUI text; 
    int score;
     
    const int SCORE_THRESHOLD_PER_LEVEL = 15;

    

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

        if (score >= 15)
        {
             SceneManager.LoadScene("Town");
        }
    }

}