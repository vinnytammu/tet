using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imaginariesCollide : MonoBehaviour {

    public spawnImaginary spawnManager;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider triggerCollider)
    {
        if (triggerCollider.tag == "join imaginary")
        {

            spawnManager.hasCollided(transform, triggerCollider.transform);     //transform and triggerCollider.transform 
                                                                                // Debug.Log(transform + triggerCollider.transform)  
        }
    }

}
