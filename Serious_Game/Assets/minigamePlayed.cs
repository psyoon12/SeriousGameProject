using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigamePlayed : MonoBehaviour
{

    public static minigamePlayed Instance;

    [SerializeField] bool[] played;

    // Start is called before the first frame update
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

    void start(){
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setPlayed(int index){
        played[index] = true;
    }

    public bool getPlayed(int index){
        return played[index];
    }

    public bool gameOver(){
        bool over = true;
        foreach (bool item in played)
        {
            if(!item){
                over = false;
            }
        }

        return over;
    }
}
