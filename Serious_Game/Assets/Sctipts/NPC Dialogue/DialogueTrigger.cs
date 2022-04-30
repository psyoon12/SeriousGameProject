using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogueScript;
    private bool playerDetected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerDetected = true;
            dialogueScript.ToggleNotification(playerDetected);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerDetected = false;
            dialogueScript.ToggleNotification(playerDetected);
            dialogueScript.EndDialogue();
        }
    }

    private void Update()
    {
        if (playerDetected && Input.GetKeyDown(KeyCode.Space))
        {
            dialogueScript.startDialogue();
        }
    }
}
