using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//original code from Media Max: https://www.youtube.com/watch?v=FtcdkfvrQv0 


[RequireComponent(typeof(Rigidbody))]
public class imaginaryFloat : MonoBehaviour {
    public float waterLevel = 0.0f;
    public float floatThreshold = 2.0f;
    public float waterDensity = 0.125f;
    public float downForce = 4.0f;

    float forceFactor;
    Vector3 floatForce;

    void FixedUpdate()
    {
        forceFactor = 1.0f - ((transform.position.y - waterLevel) / floatThreshold);

        if (forceFactor > 0.0f)
        {
            floatForce = -Physics.gravity * (forceFactor - GetComponent<Rigidbody>().velocity.y * waterDensity);
            floatForce = new Vector3(0.0f, -downForce, 0.0f);               //* GetComponent<Rigidbody> ().mass     multiply by this in order to eliminate mass of object as a factor
            GetComponent<Rigidbody>().AddForceAtPosition(floatForce, transform.position);
        }
    }
}
