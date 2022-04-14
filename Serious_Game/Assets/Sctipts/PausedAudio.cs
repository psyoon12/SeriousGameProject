using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausedAudio : MonoBehaviour
{
    private bool muted = false;
    
    public void onButtonPress() 
    {
        if(muted == false) 
        {
            muted = true;
            AudioListener.pause = true;
        }
        else 
        {
            muted = false; 
            AudioListener.pause = false;
        }
    }

    
}
