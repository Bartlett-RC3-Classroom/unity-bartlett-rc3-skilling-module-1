using UnityEngine;

// CLASS

public class Humanoid
{
     // VARIABLES

     string firstName;
     string familyName;

     int age;
     float height;

     // CONSTRUCTOR
     public Humanoid(string first, string last)
     {
         firstName = first;
         familyName = last;
         age = 0;
         height = 0.5f;
     }

     // METHODS (FUNCTIONS)
     private void Ageing()
     {
         age = age + 1;
     }
     private void Growing()
     {
         height = height + 0.1f;
     }

     public void Communicate()
     {
         Debug.Log("Hello, my name is " + firstName + " " + familyName + ".");
     }
}
