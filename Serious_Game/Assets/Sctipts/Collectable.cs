using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public int collectableValue = 5;
    [SerializeField] AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        
        if (audio == null)
        {
            audio = GetComponent<AudioSource>();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        AudioSource.PlayClipAtPoint(audio.clip, transform.position);
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.UpdateScore(collectableValue);
            //Time.timeScale = 0f;
        }
    }
}
