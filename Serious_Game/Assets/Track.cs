using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Track : MonoBehaviour
{
    [SerializeField]public float TimeBeforeLoading = 2f;
    public static Track Instance;
    private float timeElapsed;
    
    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    } 

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(minigamePlayed.Instance.gameOver()&&SceneManager.GetActiveScene().buildIndex == 1){
            timeElapsed += Time.deltaTime;
            if (timeElapsed > TimeBeforeLoading){
                Debug.Log("Game Over!");
                SceneManager.LoadScene("HighScore");
            }
        } else{

        }
    }
}
