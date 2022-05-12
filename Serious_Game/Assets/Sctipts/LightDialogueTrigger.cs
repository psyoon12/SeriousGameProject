using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDialogueTrigger : MonoBehaviour
{
    public LightDialogue LightdialogueScript;
    private bool playerDetected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerDetected = true;
            LightdialogueScript.ToggleNotification(playerDetected);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerDetected = false;
            LightdialogueScript.ToggleNotification(playerDetected);
            LightdialogueScript.EndDialogue();
        }
    }

    private void Update()
    {
        if (playerDetected && Input.GetKeyDown(KeyCode.Space))
        {
            LightdialogueScript.startDialogue();
        }
    }
}