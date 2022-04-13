using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NpcMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] bool leftLeft = false;
    [SerializeField] bool moving = true;
    [SerializeField] bool enter = true;
    [SerializeField] float movement;
    [SerializeField] float force = -2f;
    [SerializeField] Text dialogue;
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        if (rigid == null){
            rigid = GetComponent<Rigidbody2D>();
        }
        if (animator==null){
            animator = gameObject.GetComponent<Animator>();
        }
        GameObject canvasObject = GameObject.FindGameObjectWithTag("Canvas");
        Transform textTr = canvasObject.transform.Find("Dialogue");
        dialogue = textTr.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenMid = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width/2, Screen.height/2));
        Vector2 screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        movement = Input.GetAxis("Horizontal");
        if (transform.position.x<=screenMid.x+3){
            leftLeft=true;
            moving=false;
            animator.SetBool("wait", true);
        }

        if  (Input.GetKey("y")||Input.GetKey("n")){
            Debug.Log("y or n pressed");
            moving=true;
            animator.SetBool("wait", false);
            dialogue.text="";
            enter=false;
        }

        if (!enter&&transform.position.x>=screenBounds.x){
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void FixedUpdate(){
        if(moving) {
            move();
        } else{
            rigid.velocity = Vector2.zero;
            dialogue.text="this is going to be ......";
        }
    }

    void move(){
        if (leftLeft){
            force = -force;
            leftLeft=false;
            transform.Rotate(0, 180, 0);
        }
        rigid.velocity = new Vector2(movement + force, 0);
    }

}
