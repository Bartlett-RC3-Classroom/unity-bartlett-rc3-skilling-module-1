using UnityEngine;

public class Session2_26 : MonoBehaviour
{
    // Gameobjects to control
    public GameObject object1;
    public int number1 = 10;

    public int[] logNumbers = new int[10];
    int logStart = 5;
    
    int logIncrement = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logNumbers[0] = logStart;
        // Conditionals if(qursion) {in case of true actions} else {in case of false actions}
        // Ask if the the object is active in the scene
        if(object1.active == true)
        {
            // If the object is active, print a message to the console
            Debug.Log("The object is active in the scene.");
        }
        else
        {
            // If the object is not active, print a different message to the console
            Debug.Log("The object is not active in the scene.");
        }

        // Conditionals concatenated with logical operators if(qursion) {in case of true actions} else {in case of false actions}
        if(object1.active == true && number1 > 5)
        {
            // If the object is active, print a message to the console
            Debug.Log("The object is active in the scene.");
        }

        // Conditionals with or logical operator if(qursion) {in case of true actions} else {in case of false actions}
        if(object1.active == true || number1 > 5)
        {
            // If the object is active, print a message to the console
            Debug.Log("The object is active in the scene.");
        }

        // Loops for tyoe of loop (counter, end condition, step)
        for (int counter = 1; counter < 10; counter = counter + 1)
        {

            logNumbers[counter] = logNumbers[counter - 1] + logIncrement;
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        // Loop foreach type of loop (counter, end condition, step)
        int counter = 0;
        foreach (int currentInt in logNumbers)
        {
            int increaseValue = currentInt + Random.Range(1, 10);
            logNumbers[counter] = increaseValue;
            counter++;            
        }

        // While loop (needs a condtion to end)
        int whileCounter = 0;
        while (whileCounter < logNumbers.Length-1)
        {
            logNumbers[whileCounter] = logNumbers[whileCounter] - Random.Range(3, 10);
            whileCounter++;
        }

        // Loop type


        // Conditionals if(qursion) {in case of true actions} else {in case of false actions}
        // Ask if the the object is active in the scene
        if(object1.active == true)
        {
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                object1.transform.Translate(new Vector3(-0.5f, 0, 0));
                Debug.Log("The object is active in the scene and should move left.");
            }
            if(Input.GetKey(KeyCode.RightArrow))
            {
                object1.transform.Translate(new Vector3(0.5f, 0, 0));
                Debug.Log("The object is active in the scene and should move right.");
            }
            
        }

    }
}
