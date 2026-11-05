//LIBRARYs
using UnityEngine;
using System.IO;

public class Session3_25 : MonoBehaviour
{
    // VARIABLES
    public GameObject myCube;
    private bool moveForward = true;
    private bool useSphere = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the cube around its Y axis at 1 degree per second
        myCube.transform.Rotate(0, 1, 0); // Rotate (x, y, z)

        //Translate the cube forward in the z axis at 1 unit per second
        if (myCube.transform.position.z > 10) moveForward = false;
        if (myCube.transform.position.z < -10) moveForward = true;


        if (moveForward == true)
            myCube.transform.Translate(10 * Time.deltaTime * Vector3.forward, Space.World); // Translate (x, y, z)
        if (moveForward == false)
            myCube.transform.Translate(-10 * Time.deltaTime * Vector3.forward, Space.World); // Translate (x, y, z)

        // Randomly scale the cube in the x axis between 1 and 3
        float randomScaleX = Random.Range(1f, 3f);
        float randomScaleY = Random.Range(1f, 3f);
        float randomScaleZ = Random.Range(1f, 3f);
        myCube.transform.localScale = new Vector3(randomScaleX, randomScaleY, randomScaleZ);

        // Keyboard Input to change mesh filter
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed.");
            MeshFilter meshFilter = myCube.GetComponent<MeshFilter>();
            Debug.Log(meshFilter.mesh.name);
            if (meshFilter.mesh.name.Contains("Cube"))
            {
                Debug.Log("Found the cube!");
                meshFilter.mesh = Resources.GetBuiltinResource<Mesh>("Sphere.fbx");
                useSphere = true;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left mouse button was pressed.");
            MeshFilter meshFilter = myCube.GetComponent<MeshFilter>();
            Debug.Log(meshFilter.mesh.name);
            if (meshFilter.mesh.name.Contains("Sphere"))
            {
                Debug.Log("Found the sphere!");
                meshFilter.mesh = Resources.GetBuiltinResource<Mesh>("Cube.fbx");
                useSphere = false;
            }
        }

        // Instantiate a new cube where myCube is located 
        GameObject newCube;
        newCube = Instantiate(myCube, myCube.transform.position, Quaternion.identity); // Instantiate (object, position, rotation)
        newCube.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value); // Change color to random color

        if (Input.GetKeyDown(KeyCode.W))
        {
            myCube.transform.Translate(Vector3.up, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            myCube.transform.Translate(Vector3.down, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            myCube.transform.Translate(Vector3.left, Space.World);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            myCube.transform.Translate(Vector3.right, Space.World); 
        }
    }
}
