using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    public string value; // the value we assign to the button
    public DisplayController displayController; // reference to displayController script
    public static Calculator calculator = new Calculator();


    public void Start()
    {
        displayController = GameObject.Find("DisplayPanel").GetComponent<DisplayController>();
    }


    // append the value of the button to the text
    public void AppendValueToDisplay() // just added this argument
    {
        displayController.UpdateDisplayText(value);
        // this adds the operator to the value and we don't want that
        //calculator.setFirstOprand(value);
    }


    public void AppendValueToOprand(string numberEntered)
    {
        Debug.Log("calculator.GetSelectedOperator() returns: " + calculator.GetSelectedOperator());

        // this is where we'll check if an operator has been picked so we'll know if it's first or second
        if(calculator.GetSelectedOperator() == "")
        {
            Debug.Log("no operator has been selected so we'll append to the 1st oprand");
            //string tempOprand = calculator.GetFirstOprand();
            calculator.setFirstOprand(numberEntered);
        } 
        else
        {
            Debug.Log("there IS an operator selected so we'll append to the 2nd oprand");
            calculator.SetSecondOprand(numberEntered);
        }


    }

    public void SelectOperator(string selectedOperator)
    {
        //calculator.setFirstOprand(value);
        calculator.SetOperator(selectedOperator);
        Debug.Log("GetSelectedOperator: " + calculator.GetSelectedOperator());
        calculator.ToggleOperatorBeenSelectedToTrue();
    }

    public void EvaluateEquation()
    {
        displayController.DisplayAnswer();
    }

    public void Clear()
    {
        displayController.ClearDisplay();
        calculator.ClearFirstOperand();
        calculator.ClearSecondOperand();
        calculator.ClearSelectedOperator();
    }
}
