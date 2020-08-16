using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBoat : MonoBehaviour {

    private Rigidbody rbody;
    public float turnSpeed = 1000f;
    public float accellerateSpeed = 1000f; 

	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody>(); 
	}
	
	// Update is called once per frame
	void Update () {

        
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //print(h); 

        rbody.AddTorque(0f, h * turnSpeed * Time.deltaTime, 0);
        rbody.AddForce(transform.forward * v * accellerateSpeed * Time.deltaTime); 
	}
}
