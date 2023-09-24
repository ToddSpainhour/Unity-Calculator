using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayController : MonoBehaviour
{
    // what the user sees when the enter a value
    private Text displayText; 

    // reference to to Calculator script store in gameObject called Calculator
    public Calculator calculator; 


    public void Start()
    {
        displayText = GameObject.Find("DisplayText").GetComponent<Text>();

    }


    public void ClearDisplay()
    {
        displayText.text = "";
    }


    public void UpdateDisplayText(string newText)
    {
        if (newText == "." && calculator.GetOperandHasDecimalPoint())
        {
            displayText.text += "";
        } 
        else
        {
            displayText.text += newText;
        }
    }


    public void DisplayAnswer()
    {
        string solution = calculator.Calculate();
        displayText.text = solution;
    }
}
