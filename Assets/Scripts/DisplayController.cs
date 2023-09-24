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
        // this connects this variable to a gameObject in Unity
        displayText = GameObject.Find("DisplayText").GetComponent<Text>();

    }


    // changes display text to be empty string
    public void ClearDisplay()
    {
        displayText.text = "";
    }


    // this concatenates entered values to displayed text; prevents duplicate decimal points from being displayed
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


    // calls methot to solve math problem and display returned value
    public void DisplayAnswer()
    {
        string solution = calculator.Calculate();
        displayText.text = solution;
    }
}
