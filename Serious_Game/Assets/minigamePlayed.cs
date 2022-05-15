using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigamePlayed : MonoBehaviour
{

    public static minigamePlayed Instance;

    [SerializeField] GameObject[] minigame;
    //[SerializeField] bool[] played;

    // Start is called before the first frame update
    void Start()
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

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setPlayed(string tag){
        int index;

        foreach (GameObject g in minigame){
            if (g.CompareTag(tag)){
                g.SetActive(false);
            }
        }
    }
}
