using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playText : MonoBehaviour {

    public Transform text;

    public void SetActiveText()
    {
        text.gameObject.SetActive(true);
    }

    public void DeactivateText()
    {
        text.gameObject.SetActive(false);
    }
}
