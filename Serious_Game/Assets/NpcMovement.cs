using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] bool leftLeft = false;
    [SerializeField] bool moving = true;
    [SerializeField] float movement;
    [SerializeField] float force = -2f;
    // Start is called before the first frame update
    void Start()
    {
        if (rigid == null){
            rigid = GetComponent<Rigidbody2D>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width/2, Screen.height/2));
        movement = Input.GetAxis("Horizontal");
        if (transform.position.x<=screenBounds.x){
            leftLeft=true;
            moving=false;
        }

        if  (Input.GetKey("y")||Input.GetKey("n")){
            Debug.Log("y pressed");
            moving=true;
        }
    }

    void FixedUpdate(){
        if(moving) {
            move();
        } else{
            rigid.velocity = Vector2.zero;
            rigid.Sleep();
        }
    }

    void move(){
        if (leftLeft){
            force = -force;
            leftLeft=false;
            transform.Rotate(0, 180, 0);
        }
        rigid.velocity = new Vector2(movement - (force), 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

}
