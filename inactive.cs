using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script for when the user lets go or is not holding onto an imaginary bubble 

public class inactive : MonoBehaviour {

    public playText textDeactivate; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.GetChild(0).gameObject.activeSelf == true)                                            //if child object is already active
        {                           
            if (!(transform.GetComponent<DistanceGrabbable>().isGrabbed))                                   //if the object is NOT grabbed 
            {
                transform.GetChild(0).gameObject.SetActive(false);                                              //then turn off the child object 
                textDeactivate.DeactivateText(); 
            }
        }
	}
}
