using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        //SceneManager.LoadScene(3);
        //Thief
        if (!minigamePlayed.Instance.getPlayed(1)){
            SceneManager.LoadScene(3);
            minigamePlayed.Instance.setPlayed(1);
        }
    }
}
