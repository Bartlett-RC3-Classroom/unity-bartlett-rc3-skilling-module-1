using UnityEngine;

public class CubeHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W key was pressed.");
            gameObject.transform.Translate(Vector3.up * 1.0f);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S key was pressed.");
            gameObject.transform.Translate(Vector3.down * 1.0f);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D key was pressed.");
            gameObject.transform.Translate(Vector3.right * 1.0f);
        }   
        
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A key was pressed.");
            gameObject.transform.Translate(Vector3.left * 1.0f);
        }  
    }
}
