using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] int happyScale = 100;
    [SerializeField] int poplulationScale = 100;
    [SerializeField] int wealthSacle = 100;
    [SerializeField] int militaryScale = 100;
    [SerializeField] int civilRightScale = 100;
    [SerializeField] Text happyTxt;
    [SerializeField] Text poplulationTxt;
    [SerializeField] Text wealthTxt;
    [SerializeField] Text militaryTxt;
    [SerializeField] Text civilRightTxt;

    // Start is called before the first frame update
    void Start()
    {
        if (happyTxt==null){
            GameObject canvasObject = GameObject.FindGameObjectWithTag("Canvas");
            Transform textTr = canvasObject.transform.Find("Happy");
            happyTxt = textTr.GetComponent<Text>();
        }
        if (poplulationTxt==null){
            GameObject canvasObject = GameObject.FindGameObjectWithTag("Canvas");
            Transform textTr = canvasObject.transform.Find("Population");
            poplulationTxt = textTr.GetComponent<Text>();
        }
        if (wealthTxt==null){
            GameObject canvasObject = GameObject.FindGameObjectWithTag("Canvas");
            Transform textTr = canvasObject.transform.Find("Wealth");
            wealthTxt = textTr.GetComponent<Text>();
        }
        if (militaryTxt==null){
            GameObject canvasObject = GameObject.FindGameObjectWithTag("Canvas");
            Transform textTr = canvasObject.transform.Find("Military");
            militaryTxt = textTr.GetComponent<Text>();
        }
        if (civilRightTxt==null){
            GameObject canvasObject = GameObject.FindGameObjectWithTag("Canvas");
            Transform textTr = canvasObject.transform.Find("CivilRight");
            civilRightTxt = textTr.GetComponent<Text>();
        }

        DisplayScale();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScale(string[] scale,int[] point){
        for (int i=0; i<scale.Length;i++){
            switch (scale[i])
            {
                case "happy":
                    happyScale+=point[i];
                    break;
                case "pop":
                    poplulationScale+=point[i];    
                    break;
                case "wealth":
                    wealthSacle+=point[i];    
                    break;
                case "military":
                    militaryScale+=point[i];
                    break;
                case "cr":
                    civilRightScale+=point[i];
                    break;
                default:
                    break;
            }
        }
        
        DisplayScale();
    }

    public void DisplayScale(){
        happyTxt.text = "Happiness: " + happyScale;
        poplulationTxt.text = "Population: " + poplulationScale;
        wealthTxt.text = "Wealth: " + wealthSacle;
        militaryTxt.text = "Military: " + militaryScale;
        civilRightTxt.text = "Civil Right: " + civilRightScale;
    }

}
