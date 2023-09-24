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
        // connects variable to game object in Unity
        displayController = GameObject.Find("DisplayPanel").GetComponent<DisplayController>();
    }


    // append the value of the button to the displayed text
    public void AppendValueToDisplay()
    {
        displayController.UpdateDisplayText(value);
    }


    // appends numbers entered to the current operand; calls method to track if operand has decimal point 
    public void AppendValueToOprand(string numberEntered)
    {
        // this is where we'll check if an operator has been picked so we'll know if it's first or second
        if(calculator.GetSelectedOperator() == "")
        {
            if (numberEntered == ".")
            {
                if(calculator.GetOperandHasDecimalPoint() == false)
                {
                    calculator.SetOperandHasDecimalPointToTrue();
                    calculator.SetFirstOperand(numberEntered);
                }
            } 
            else
            {
                calculator.SetFirstOperand(numberEntered);
            }
        } 
        else
        {
            if(numberEntered == ".")
            {
                if(calculator.GetOperandHasDecimalPoint() == false)
                {
                    calculator.SetOperandHasDecimalPointToTrue();
                    calculator.SetSecondOperand(numberEntered);
                }
            } 
            else
            {
                calculator.SetSecondOperand(numberEntered);
            }
        }
    }


    // calls setOperator method and method to track if operator has been selected
    public void SelectOperator(string selectedOperator)
    {
        calculator.SetOperandHasDecimalPointToFalse();
        calculator.SetOperator(selectedOperator);
        calculator.ToggleOperatorBeenSelectedToTrue();
    }


    // calls method to display answer
    public void EvaluateEquation()
    {
        displayController.DisplayAnswer();
    }


    // clears out display values and all variables in the Model
    public void Clear()
    {
        displayController.ClearDisplay();
        calculator.ClearFirstOperand();
        calculator.ClearSecondOperand();
        calculator.ClearSelectedOperator();
        calculator.SetOperandHasDecimalPointToFalse();
    }


    // terminates application
    public void QuitApplication()
    {
        Application.Quit();
    }
}
