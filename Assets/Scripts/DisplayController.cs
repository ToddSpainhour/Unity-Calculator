using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayController : MonoBehaviour
{
    // what the user sees when the enter a value
    private Text displayText; 
    // reference to to Calculator script store in gameObject called Calculator
    public Calculator calculator; 


    // Start is called before the first frame update
    void Start()
    {
        displayText = GameObject.Find("DisplayText").GetComponent<Text>();
    }

    public void ClearDisplay()
    {
        displayText.text = "";
    }

    public void UpdateDisplayText(string newText)
    {
        displayText.text = newText;
    }

    public void DisplayAnswer()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
