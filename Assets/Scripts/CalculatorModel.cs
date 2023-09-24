using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculatorModel : MonoBehaviour
{

    // this file is the Model; these properties hold the data we need
    public string firstOperand;
    public string secondOperand;
    public bool operandHasDecimalPoint = false;
    public bool operatorBeenSelected;
    public string selectedOperator = "";
    public float result;
}
