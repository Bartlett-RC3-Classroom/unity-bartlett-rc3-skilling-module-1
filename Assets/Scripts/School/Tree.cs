// LIBRARIES
using UnityEngine;

// CLASS
public class Tree
{

    // VARIABLES/PROPERTIES
    public string type;
    public float height;
    public float age;
    public float mass;
    public bool isBlooming = true;

    public Vector3 position;

    private bool hasWater = true;
    private bool isSick;

    private GameObject treeObject;

    // CONSTRUCTOR
    public Tree(string _type, float _height)
    {
        type = _type;
        height = _height;
        age = 0;
        mass = 1.0f;
        isBlooming = false;
        isSick = false;
        position = new Vector3(UnityEngine.Random.Range(0,10),0,UnityEngine.Random.Range(0,10)); // x, 0, z
    }

    // METHODS/FUNCTIONS/
    public void Grow()
    {
        // Code for growing
        if (hasWater && isBlooming)
        {
            height = height + 0.5f;
            mass += 0.3f; // shorthand
        }

        if (hasWater || !isBlooming)
        {
              height = height + 0.5f;
            mass += 0.01f;
        }
        else
        {
              height = height + 0.5f;
            mass -= 0.1f;
        }
    }
    
    public void UpdateGameObject()
    {
        treeObject.transform.localScale = new Vector3(1, height, 1);
        Debug.Log("Tree height is: " + height.ToString());
    }

    void OberveSeasonChange(string _season)
    {
        // Code for observing season change
        if (_season == "Spring")
        {
            isBlooming = true;
        }
        else
        {
            isBlooming = false;
        }
    }

    // GETTERS AND SETTERS
    public void SetHasWater(bool _hasWater)
    {
        hasWater = _hasWater;
    }
    public bool GetHasWater()
    {
        return hasWater;
    }

    public bool GetIsTheTreeHealthy()
    {
        return !isSick;
    }

    public void SetGameObject(GameObject _treeObject)
    {
        treeObject = _treeObject;
    }
}
