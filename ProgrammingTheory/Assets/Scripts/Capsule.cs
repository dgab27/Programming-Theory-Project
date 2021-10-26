using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    //INHERITANCE (child class)
    // Start is called before the first frame update
    void Start()
    {
        OverrideValues();
    }

    //Setting the ENCAPSULATED values in a custom method in a child script - INHERITANCE
    public void OverrideValues()
    {
        ScoreToGive = 3;
        ShapeName = "Capsule";
    }
    
    //Overriding a method - POLYMORPHISM
    public override void DisplayText()
    {
        textToDisplay.text = "Player caught: " + ShapeName + " and received " + ScoreToGive + " score" + " nice Capsule!";
    }
}
