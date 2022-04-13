using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] int happyScale = 100;
    [SerializeField] TextMeshProUGUI happyText;
    [SerializeField] int populationScale = 100;
    [SerializeField] TextMeshProUGUI populationText;
    [SerializeField] int wealthScale = 100;
    [SerializeField] TextMeshProUGUI wealthText;
    [SerializeField] int militaryScale = 100;
    [SerializeField] TextMeshProUGUI militaryText;
    [SerializeField] int civilrightScale = 100;
    [SerializeField] TextMeshProUGUI civilrightText;
    // Start is called before the first frame update
    void Start()
    {
        if (happyText==null){
            GameObject canvasObject = GameObject.FindGameObjectWithTag("Canvas");
            Transform textTr = canvasObject.transform.Find("Happy");
            happyText = textTr.GetComponent<TextMeshProUGUI>();
        }

        if (populationText==null){
            GameObject canvasObject = GameObject.FindGameObjectWithTag("Canvas");
            Transform textTr = canvasObject.transform.Find("Population");
            populationText = textTr.GetComponent<TextMeshProUGUI>();
        }

        if (wealthText==null){
            GameObject canvasObject = GameObject.FindGameObjectWithTag("Canvas");
            Transform textTr = canvasObject.transform.Find("Wealth");
            wealthText = textTr.GetComponent<TextMeshProUGUI>();
        }

        if (militaryText==null){
            GameObject canvasObject = GameObject.FindGameObjectWithTag("Canvas");
            Transform textTr = canvasObject.transform.Find("Military");
            militaryText = textTr.GetComponent<TextMeshProUGUI>();
        }

        if (civilrightText==null){
            GameObject canvasObject = GameObject.FindGameObjectWithTag("Canvas");
            Transform textTr = canvasObject.transform.Find("CivilRight");
            civilrightText = textTr.GetComponent<TextMeshProUGUI>();
        }        
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }
}
