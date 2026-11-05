using UnityEngine;

public class HandControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Sping the hand around the local z ais
        transform.Rotate(0, 0, 1);
    }
}
