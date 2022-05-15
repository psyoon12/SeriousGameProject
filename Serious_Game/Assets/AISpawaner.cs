using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AISpawaner : MonoBehaviour
{
    [SerializeField] GameObject[] AI;
    [SerializeField] Transform PlayerPos;
    [SerializeField] GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        if (Player==null){
            Player = GameObject.FindGameObjectWithTag("Player");
        } 
        if (PlayerPos==null){
            PlayerPos = Player.GetComponent<Transform>();
        }
        Spwan();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spwan(){
        int index = SceneManager.GetActiveScene().buildIndex - 2;
        Vector2 position = new Vector2(PlayerPos.position.x-4,PlayerPos.position.y+2);
        Instantiate(AI[index], position, Quaternion.identity);
    }
}
