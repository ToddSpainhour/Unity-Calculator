using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public static CalculatorModel calculatorModel = new CalculatorModel();
    public string Calculate()
    {
        float num1 = float.Parse(GetFirstOprand());
        float num2 = float.Parse(GetSecondOprand());

        Debug.Log("calculate method equation argument: ");
        float tempResult = 0
            ;
        switch (GetSelectedOperator())
        {
            case "+":
                tempResult = num1 + num2;
                SetResult(tempResult);
                Debug.Log("calculator.result: + " + calculatorModel.result);
                break;
            case "-":
                tempResult = num1 - num2;
                SetResult(tempResult);
                Debug.Log("calculator.result: - " + calculatorModel.result);
                break;
            case "*":
                tempResult = num1 * num2;
                SetResult(tempResult);
                Debug.Log("calculator.result: * " + calculatorModel.result);
                break;
            case "/":
                tempResult = num1 / num2;
                SetResult(tempResult);
                Debug.Log("calculator.result: / " + calculatorModel.result);
                break;
            default:
                Debug.Log("oh no something went wrong in the case in calculator");
                break;
        }


        string solution = calculatorModel.result.ToString();
        return solution;
    }

    public string GetFirstOprand()
    {
        return calculatorModel.firstOperand;
    }


    public void setFirstOprand(string valuePassedIn)
    {
        //string tempFirstprand = GetFirstOprand();
        calculatorModel.firstOperand += valuePassedIn;
        Debug.Log("GetFirstOprand(): " + GetFirstOprand());
    }


    public string GetSecondOprand()
    {
        return calculatorModel.secondOperand;
    }


    public void SetSecondOprand(string valuePassedIn)
    {
        //string tempSecondOprand = GetSecondOprand();

        calculatorModel.secondOperand += valuePassedIn;
        Debug.Log("GetSecondOprand() " + GetSecondOprand());
    }


    public string GetSelectedOperator()
    {
        return calculatorModel.selectedOperator;
    }


    public void SetOperator(string selectedOperatorArgument)
    {
        //Debug.Log("setOperator: " + selectedOperatorArgument);
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
