using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public static CalculatorModel calculatorModel = new CalculatorModel();
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

    public string GetFirstOperand()
    {
        return calculatorModel.firstOperand;
    }


    public void SetFirstOperand(string valuePassedIn)
    {
        calculatorModel.firstOperand += valuePassedIn;
    }


    public string GetSecondOperand()
    {
        return calculatorModel.secondOperand;
    }


    public void SetSecondOperand(string valuePassedIn)
    {
        calculatorModel.secondOperand += valuePassedIn;
    }


    public string GetSelectedOperator()
    {
        return calculatorModel.selectedOperator;
    }


    public void SetOperator(string selectedOperatorArgument)
    {
        calculatorModel.selectedOperator = selectedOperatorArgument;
    }


    public void ToggleOperatorBeenSelectedToTrue()
    {
        calculatorModel.operatorBeenSelected = true;
    }


    public void ToggleOperatorBeenSelectedToFalse()
    {
        calculatorModel.operatorBeenSelected = false;
    }


    public void SetOperandHasDecimalPointToTrue()
    {
        calculatorModel.operandHasDecimalPoint = true;
    }


    public void SetOperandHasDecimalPointToFalse()
    {
        calculatorModel.operandHasDecimalPoint = false;
    }


    public bool GetOperandHasDecimalPoint()
    {
        return calculatorModel.operandHasDecimalPoint;
    }


    public void ClearFirstOperand()
    {
        calculatorModel.firstOperand = "";
    }


    public void ClearSecondOperand()
    {
        calculatorModel.secondOperand = "";
    }


    public void ClearSelectedOperator()
    {
        calculatorModel.selectedOperator = "";
    }


    public void SetResult(float passedInValue)
    {
        calculatorModel.result = passedInValue;
    }
}
