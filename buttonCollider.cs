using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems; 

public class buttonCollider : MonoBehaviour
{
    public Transform boat; 
    public UnityEvent onButtonTrigger;
    public UnityEvent onReturn;
    bool hasBeengrabbed; 

    void Start()
    {
        hasBeengrabbed = false;  
    }

    void Update()
    {   
        if (hasBeengrabbed == true)                                                                     //|| transform.GetComponent<DistanceGrabbable>().isGrabbed
        {
            transform.parent = boat.transform;                                                        //temporary solution for making sure the spheres travel with the boat
            //transform.position = Vector3.MoveTowards(transform.position, boat.position, 1);             //develop this further to keep spheres in bounds of boat 
        }
    }

    public void OnTriggerStay()
    {
        if (OVRInput.GetDown(OVRInput.Button.One) || OVRInput.GetDown(OVRInput.Button.Three))                 //if button 'a' or 'x' has been pressed...
        {   
            if (onButtonTrigger != null)
            {
                if (transform.GetComponent<DistanceGrabbable>().isGrabbed)                                  //make sure that the sphere has actually been grabbed before invoking the button. maybe this should be at the beginning of the if block
                {
                    hasBeengrabbed = true; 
                    onButtonTrigger.Invoke();
                    Debug.Log("buttonOne pressed");
                }
            }
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryThumbstick) && OVRInput.GetDown(OVRInput.Button.SecondaryThumbstick))
        {
            if (onReturn != null)
            {
                onReturn.Invoke();
                Debug.Log("thumbStick pressed Down");
                
            }
        }

       /* if (Input.GetKeyDown(KeyCode.Return))
        {
            if (onReturn != null)
            {
                onReturn.Invoke();
            }
        } */
    }
}