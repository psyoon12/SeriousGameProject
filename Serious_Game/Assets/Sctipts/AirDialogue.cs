using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDialogueTrigger : MonoBehaviour
{
    public AirDialogue AirdialogueScript;
    private bool playerDetected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerDetected = true;
            AirdialogueScript.ToggleNotification(playerDetected);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerDetected = false;
            AirdialogueScript.ToggleNotification(playerDetected);
            AirdialogueScript.EndDialogue();
        }
    }

    private void Update()
    {
        if (playerDetected && Input.GetKeyDown(KeyCode.Space))
        {
            AirdialogueScript.startDialogue();
        }
    }
}
