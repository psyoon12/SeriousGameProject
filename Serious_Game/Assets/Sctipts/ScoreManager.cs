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
    int Collectable;
     
    const int SCORE_THRESHOLD_PER_LEVEL = 15;

    

    void Start()
    { 
        score = PersistentData.Instance.GetScore();
        text.text = "Score: " + score.ToString();
        if (instance == null)
        {
            instance = this;
        }
    } 

    void FixedUpdate(){

        Collectable = GameObject.FindGameObjectsWithTag("Collectable").Length;

        if (Collectable == 0)
        {
             SceneManager.LoadScene("Town");
        }
    }

    public void UpdateScore(int addend)
    {
        score += addend;
        text.text = "Score: " + score.ToString();

        PersistentData.Instance.SetScore(score);
    }

}