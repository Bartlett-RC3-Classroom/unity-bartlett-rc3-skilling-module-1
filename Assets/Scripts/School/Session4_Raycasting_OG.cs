using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_Raycasting_OG : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Ray casting steps

        // Step 1: Create ray
        Vector3 raycastingDirection = transform.forward;

        // Step 2: See that object is in front of me
        RaycastHit obecjInFront;
        Debug.DrawRay(transform.position, transform.forward, Color.green); 

        // Setp 3: Do soething with the object in fron of me
        if(Physics.Raycast(transform.position+Vector3.forward*2,raycastingDirection, out obecjInFront)){
            Debug.Log("Object in front is:" + obecjInFront.transform.name);
            obecjInFront.transform.GetComponent<Renderer>().material.color = Color.yellow;
            //obecjInFront.transform.GetComponent<ListenScript>().seen = true;
            
        }

		
	}
}
