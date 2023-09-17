using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculatorModel : MonoBehaviour
{

    // created properties for the model
    public string firstOperand;
    public string secondOperand;
    public bool operatorBeenSelected;
    public string selectedOperator = "";
    public float result;
    
    void Start()
    {
        Debug.Log("CalculatorModel script just started");
    }

}
