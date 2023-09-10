using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    public string value; // the value we assign to the button
    public DisplayController displayController; // reference to displayController script


    public void Start()
    {
        displayController = GameObject.Find("DisplayPanel").GetComponent<DisplayController>();
    }


    // append the value of the button to the text
    public void AppendValueToDisplay() // just added this argument
    {
        Debug.Log("inside AppendValueToDisplay method " + this.value.ToString());
        displayController.UpdateDisplayText(value);
    }

    public void EvaluateEquation()
    {
        displayController.DisplayAnswer();
    }

    public void Clear()
    {
        displayController.ClearDisplay();
    }
}
