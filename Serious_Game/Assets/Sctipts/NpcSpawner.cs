using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] npcs;
    // Start is called before the first frame update
    void Start()
    {
        Spwan();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spwan(){
        int index = (int)Mathf.Floor(Random.Range(0,npcs.Length));
        Vector2 position = new Vector2(7.8f,0);
        Instantiate(npcs[index], position, Quaternion.identity);
    }
}
