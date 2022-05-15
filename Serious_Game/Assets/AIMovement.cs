using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIMovement : MonoBehaviour
{
    public Transform PlayerPos;
    public GameObject Player;
    [SerializeField] Rigidbody2D rigid;
    float MoveSpeed = 3.0f;
    float distance = 1;

    const int pointOff = -1;


    // Start is called before the first frame update
    void Start()
    {
        if (rigid == null)
            rigid = GetComponent<Rigidbody2D>();
        if (Player==null){
            Player = GameObject.FindGameObjectWithTag("Player");
        } 
        if (PlayerPos==null){
            PlayerPos = Player.GetComponent<Transform>();
        } 
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, PlayerPos.position, MoveSpeed*Time.deltaTime);

    }

    private void OnTriggerEnter2D (Collider2D collider)
    {
        if (collider.gameObject.CompareTag ("Player")){
            ScoreManager.instance.UpdateScore(pointOff);
            transform.position = new Vector3(transform.position.x-2, transform.position.y-2, transform.position.z);
        }
    }


}
