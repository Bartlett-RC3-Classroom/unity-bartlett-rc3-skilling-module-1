using UnityEngine;

public class Zombie : Humanoid
{
    // CONSTRUCTOR
    public Zombie(string first, string last) : base(first, last)
    {
        // Additional initialization for Zombie class can be added here
    }

    // METHODS (FUNCTIONS)
    public void Attack()
    {
        Debug.Log("The zombie attacks!");   
        
    }

    public void EatBrains()
    {
        Debug.Log("The zombie eats brains!");
    }
}
