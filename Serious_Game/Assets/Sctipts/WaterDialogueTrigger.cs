using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDialogueTrigger : MonoBehaviour
{
    public WaterDialogue WaterdialogueScript;
    private bool playerDetected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerDetected = true;
            WaterdialogueScript.ToggleNotification(playerDetected);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerDetected = false;
            WaterdialogueScript.ToggleNotification(playerDetected);
            WaterdialogueScript.EndDialogue();
        }
    }

    private void Update()
    {
        if (playerDetected && Input.GetKeyDown(KeyCode.Space))
        {
            WaterdialogueScript.startDialogue();
        }
    }
}