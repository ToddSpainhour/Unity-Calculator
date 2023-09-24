using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public static CalculatorModel calculatorModel = new CalculatorModel();

    // the Calculate method solves the math problem. It converts the string values to a be floats then hits a switch statement
    // which case it hits in the switch statement is determined by the selected operator
    // the solution is return to whoever called this method
    public string Calculate()
    {
        float num1 = float.Parse(GetFirstOperand());
        float num2 = float.Parse(GetSecondOperand());

        float tempResult = 0
            ;
        switch (GetSelectedOperator())
        {
            case "+":
                tempResult = num1 + num2;
                SetResult(tempResult);
                break;
            case "-":
                tempResult = num1 - num2;
                SetResult(tempResult);
                break;
            case "*":
                tempResult = num1 * num2;
                SetResult(tempResult);
                break;
            case "/":
                tempResult = num1 / num2;
                SetResult(tempResult);
                break;
            default:
                Debug.Log("oh no something went wrong in the case in calculator");
                break;
        }


        string solution = calculatorModel.result.ToString();
        return solution;
    }


    // gets first operand
    public string GetFirstOperand()
    {
        return calculatorModel.firstOperand;
    }


    // sets first operand
    public void SetFirstOperand(string valuePassedIn)
    {
        calculatorModel.firstOperand += valuePassedIn;
    }


    // gets seconds operand
    public string GetSecondOperand()
    {
        return calculatorModel.secondOperand;
    }


    // sets second operand
    public void SetSecondOperand(string valuePassedIn)
    {
        calculatorModel.secondOperand += valuePassedIn;
    }


    // gets selected operator
    public string GetSelectedOperator()
    {
        return calculatorModel.selectedOperator;
    }


    // sets operator
    public void SetOperator(string selectedOperatorArgument)
    {
        calculatorModel.selectedOperator = selectedOperatorArgument;
    }


    // sets boolean value to keep track if an operator has been set
    public void ToggleOperatorBeenSelectedToTrue()
    {
        calculatorModel.operatorBeenSelected = true;
    }


    // sets boolean value to keep track if an operator has been set
    public void ToggleOperatorBeenSelectedToFalse()
    {
        calculatorModel.operatorBeenSelected = false;
    }


    // sets boolean value to track if operand has a decimal point; we only want one per operand
    public void SetOperandHasDecimalPointToTrue()
    {
        calculatorModel.operandHasDecimalPoint = true;
    }


    // sets boolean value to track if operand has a decimal point; starts as false
    public void SetOperandHasDecimalPointToFalse()
    {
        calculatorModel.operandHasDecimalPoint = false;
    }


    // gets boolean value to determine if operand has decimal point already
    public bool GetOperandHasDecimalPoint()
    {
        return calculatorModel.operandHasDecimalPoint;
    }


    // changes first operand to be empty string
    public void ClearFirstOperand()
    {
        calculatorModel.firstOperand = "";
    }


    // changes second operand to be empty string
    public void ClearSecondOperand()
    {
        calculatorModel.secondOperand = "";
    }


    // changes selected operator to be empty string
    public void ClearSelectedOperator()
    {
        calculatorModel.selectedOperator = "";
    }


    // this setter stores the answer in the model
    public void SetResult(float passedInValue)
    {
        calculatorModel.result = passedInValue;
    }
}
