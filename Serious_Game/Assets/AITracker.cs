using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITracker : MonoBehaviour
{
    public GameObject AI;

    void Awake() {
        AI = GameObject.FindWithTag("AI");
    }

    void Start() {
        AI = GameObject.FindWithTag("AI");
    }

    public GameObject getAI(){
        return AI;
    }
}
