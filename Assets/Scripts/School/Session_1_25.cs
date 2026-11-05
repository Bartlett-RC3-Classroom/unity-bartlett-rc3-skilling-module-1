// LIBRARY
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// CLASS 
public class Session_1_25 : MonoBehaviour
{
    // VARIAABLES (DATA) -- SCOPE TYPE NAME = VALUE
    // Numbers
    public int myWholeNumber = 5;
    public float myDecimalNumber = 5.1234567890123456f;
    public double myLargeDecimalNumber = 5.12345678901234567890123456789012;

    // Text
    public char myCharacter = 'A';
    public string myText = "Hello World";

    // Logical
    public bool myTrueFalse = true;

    // Larger Data Types
    // Arrays - SCOPE TYPE NAME = VALUES
    public int[] myWholeNumberArray = new int[] { 1, 2, 4, 5 };
    // Lists - SCOPE NAME <DATA TYPE> = NEW LIST<DATA TYPE>()
    public List<int> myFirsIntList = new List<int>();
    public List<string> myStringList = new List<string>();
    public List<double> myDoubleList = new List<double>();
    
    // METHODS (FUNCTIONS)

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myFirsIntList.Add(10);
        myFirsIntList.Add(20);
        myFirsIntList.Add(30);
        // Loop
        for (int i =77; i< 98; i++)
        {
            myFirsIntList.Add(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(myFirsIntList[4]);
        Calculator();
    }

    // FUNCTIONS 
    // SCOPE TYPE NAME (PARAMETERS)
    private double AddTwoDecimalNumbers(double _FirstNumber, double _SecondNumber)
    {
        double SumResult = _FirstNumber + _SecondNumber;
        return SumResult;
    }
    
    private void Calculator()
    {
        myDoubleList.Add(AddTwoDecimalNumbers(Random.Range(-100.0f, 100.0f), Random.Range(-100.0f, 100.0f)));
    }
}
