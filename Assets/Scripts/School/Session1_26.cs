// LIBRARIES
using UnityEngine;
using System.Collections.Generic; 
using System.Collections; // Import the System.Collections namespace to use IEnumerator

public class Session1_26 : MonoBehaviour
{

    // VARIABLES -- Scope / Type / Name / Value

    // Numbers
    public int myIntNumber = 10; // An integer variable to store a number
    public float myFloatNumber = 5.5f; // A float variable to store a decimal number
    public double myDoubleNumber = 3.1234567890123456789012; // A double variable to store a more precise decimal number

    // Text
    public string myStringText = "Hello, World!"; // A string variable to store text
    
    // Logical
    private bool myBoolValue = true; // A boolean variable to store a true/false value

    // Data Structures

    // Arrays -- Scope / Type / Name / Size / Values
    public int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };
    public int[] myOtherIntArray = new int[10];
    
    public GameObject[] myGameObjects = new GameObject[5]; // A GameObject array to store multiple game objects

    // Lists -- Scope / Type / Name / Values
    public List<int> myIntList = new List<int>(); // A list of integers

    // Dictionaries -- Scope / Type / Name / Values
    public Dictionary<string, int> myDictionary = new Dictionary<string, int>(); // A dictionary

    // FUNCTIONS -- Scope / Return Type / Name / Parameters 

    private float SumNumbers(float _a, float _b)
    {
        return _a + _b; // Returns the sum of two numbers
        Debug.Log("The sum of " + _a + " and " + _b + " is: " + (_a + _b)); // Log the sum to the console
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SumNumbers(myFloatNumber, (float)myDoubleNumber); // Call the SumNumbers function with myFloatNumber and myDoubleNumber as arguments
    }

    // Update is called once per frame
    void Update()
    {
        SumNumbers(myFloatNumber, (float)myDoubleNumber);
    }
}
