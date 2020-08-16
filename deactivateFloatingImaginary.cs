using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deactivateFloatingImaginary : MonoBehaviour {

    //deactivate floating script for the latest imaginary spheres that have collided
    void OnTriggerEnter(Collider triggerCollider)
    {
        if (triggerCollider.tag == "join imaginary")                        //note that the spawned imaginaries currently still float: for the reason of future join opportunities with each other
        {
            transform.GetComponent<imaginaryFloat>().enabled = false; 

        }
    }

    /*void OnTriggerEnter (Collider triggerCollider)
    {
        if (triggerCollider.tag == "calmBounce")
        {   
            transform.GetComponent<imaginaryFloat>().enabled = false;               //turn off float script upon entering boat 
            transform.GetComponent<timelineController>().enabled = false;               //turn off respective timeline
            
        }
    }*/

    /*void OnTriggerExit(Collider triggerCollider)
    {
        transform.GetComponent<imaginaryFloat>().enabled = true;                //reEnable float script on trigger exit 
    }*/

}
