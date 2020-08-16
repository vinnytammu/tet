using System.Collections;
using System.Collections.Generic;
using UnityEditor; 
using UnityEngine;

[System.Serializable]

public struct Imaginary
{
    //public int imaginaryID;
    public int imaginary1;
    public int imaginary2;
    public int outcomeImaginary;

}

[CreateAssetMenu]

public class ImaginaryList : ScriptableObject {

   public List <Imaginary> elementsList; 
        
}
