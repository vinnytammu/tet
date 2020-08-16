using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableChildren : MonoBehaviour {


    public void SetActiveChildren()
    {
        transform.GetChild(0).gameObject.SetActive(true); 
        
    }

}
