using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreCollision : MonoBehaviour {

    public Transform grabRangeObject; 

	// Use this for initialization
	void Start () {
        Physics.IgnoreCollision(grabRangeObject.GetComponent<Collider>(), transform.GetComponent<Collider>()); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
