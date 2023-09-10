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


    // Start is called before the first frame update
    public void Start()
    {
        //Debug.Log("displayController just started");
        displayText = GameObject.Find("DisplayText").GetComponent<Text>();

        //if(displayText != null)
        //{
        //    Debug.Log("displayText is NOT null; it has a value");
        //} else
        //{
        //    Debug.Log("displayText is IS null; can find gameobject");
        //}
    }

    public void ClearDisplay()
    {
        displayText.text = "";
    }

    public void UpdateDisplayText(string newText)
    {
        Debug.Log("updateDisplayText just fired");
        displayText.text += newText;
    }

    public void DisplayAnswer()
    {
        string answer = calculator.Calculate(displayText.text);
        displayText.text = answer;
    }
}
