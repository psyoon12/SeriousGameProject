using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialogue : MonoBehaviour
{
    public GameObject window;
    // notification bubble when player walk close to the NPCs
    public GameObject notification;
    public TMP_Text dialogueText;
    public List<string> dialogues;
    public float writingSpeed;
    //Index on dialogue
    private int index;
    //Index on Characters
    private int charactersIndex;
    private bool started;
    private bool waitNext; 

    public GameObject man;
    public GameObject thief;
    public GameObject dancer;
    public GameObject monk;  

    void Start() {
        man = GameObject.FindGameObjectWithTag("Man");
        thief = GameObject.FindGameObjectWithTag("Thief");
        dancer = GameObject.FindGameObjectWithTag("Dancer");
        monk = GameObject.FindGameObjectWithTag("Monk");

        
    }
    private void Awake()
    {
        ToggleNotification(false);
        ToggleWindow(false);
    }

    private void ToggleWindow(bool show) 
    {
        window.SetActive(show);
    }

    public void ToggleNotification(bool show) 
    {
        notification.SetActive(show);
    }

    public void startDialogue() 
    {
        if (started)
        {
            return; 
        }
            
        started = true;
        ToggleWindow(true);
        //hide the notification
        ToggleNotification(false);
        GetDialogue(0); //first dialogue
    }

    private void GetDialogue(int i)
    {
        index = i;
        charactersIndex = 0; 
        dialogueText.text = string.Empty;
        StartCoroutine(Writing());
    }

    public void EndDialogue() 
    {
        started = false;
        waitNext = false;
        StopAllCoroutines();
        ToggleWindow(false);
        
        if (man != null){ 
           SceneManager.LoadScene("LandMini");
        }
        
         if (thief != null){ 
           SceneManager.LoadScene("WaterMini");
        }

       if (dancer != null){ 
           SceneManager.LoadScene("LightMini");
        }

      if (monk != null){ 
           SceneManager.LoadScene("AirMini");
        }
    }

    IEnumerator Writing()
    {
        yield return new WaitForSeconds(writingSpeed);
        string currentDialogue =  dialogues[index];
        dialogueText.text += currentDialogue[charactersIndex];
        charactersIndex++;
        if (charactersIndex < currentDialogue.Length)
        {
            yield return new WaitForSeconds(writingSpeed);
            StartCoroutine(Writing());
        }
        else 
        {
            waitNext = true;
        }

    }

    private void update()
    {
        if (!started)
        {
            return;
        }
        if (waitNext && Input.GetKeyDown(KeyCode.Space))
        {
            waitNext = false;
            index++;
            if (index < dialogues.Count)
            {
                GetDialogue(index);
            } 
            else
            {
                ToggleNotification(true);
                EndDialogue();

            }
        }
    }
}
