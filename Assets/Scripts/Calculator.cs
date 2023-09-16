using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public static CalculatorModel calculatorModel = new CalculatorModel();
    public string Calculate(string equation)
    {
        Debug.Log("calculate method equation argument: " + equation);
        string solution = "empty string";

        // do the actual calculations
        // switch statement

        // assign firstOprand when an operator is selected


        return solution;
    }

    public void setFirstOprand(string valuePassedIn)
    {

        // set whatever is passed in to the model
        string tempFirstprand = GetFirstOprand();
        calculatorModel.firstOperand = tempFirstprand + valuePassedIn;

        //calculatorModel.firstOperand += valuePassedIn;


        Debug.Log("GetFirstOprand(): " + GetFirstOprand());
    }

    public string GetFirstOprand()
    {
        return calculatorModel.firstOperand;
    }


}
