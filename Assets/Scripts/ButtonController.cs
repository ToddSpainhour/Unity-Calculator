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
    public void AppendValueToDisplay()
    {
        displayController.UpdateDisplayText(value);
    }


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
                    calculator.SetFirstOprand(numberEntered);
                }
            } 
            else
            {
                calculator.SetFirstOprand(numberEntered);
            }
        } 
        else
        {
            if(numberEntered == ".")
            {
                if(calculator.GetOperandHasDecimalPoint() == false)
                {
                    calculator.SetOperandHasDecimalPointToTrue();
                    calculator.SetSecondOprand(numberEntered);
                }
            } 
            else
            {
                calculator.SetSecondOprand(numberEntered);
                //calculator.SetOperandHasDecimalPointToFalse();
            }
        }
    }

    public void SelectOperator(string selectedOperator)
    {
        calculator.SetOperandHasDecimalPointToFalse();
        calculator.SetOperator(selectedOperator);
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
        calculator.SetOperandHasDecimalPointToFalse();
    }
}
