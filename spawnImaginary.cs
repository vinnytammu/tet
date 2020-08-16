using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 


public class spawnImaginary : MonoBehaviour
{
    public Transform Bubble3;
    public ImaginaryList imaginaries;
    public Transform toyManager;
    public Transform[] toys;
    //private videoPlayer videoPlay; 

    public void hasCollided(Transform Collider1, Transform Collider2)
    {   
        Debug.Log("hasCollided called");
        Debug.Log("Collider:" + Collider1.name + " is colliding with" + " Collider:" + Collider2.name);   //print out name of colliding objects          
        int toyIndex1 = Array.IndexOf(toys, Collider1);         //print out index number of Collider1 stored in local int var
        int toyIndex2 = Array.IndexOf(toys, Collider2);         //print out index number of Collider2 stored in local int var
        Debug.Log("toyIndex1:" + toyIndex1);
        Debug.Log("toyIndex2:" + toyIndex2);

        int sizeOfImaginaries = imaginaries.elementsList.Count ;        //size of imaginaries list stored in new int var
        Debug.Log("Size of Imaginaries List: " + sizeOfImaginaries);    

        /*Vector3 spawnPosition = new Vector3(0, 0, 0f);
        Transform newImaginary = Insta ntiate(Bubble3, spawnPosition, Quaternion.identity);
        newImaginary.transform.localScale = new Vector3(1, 1, 1f); */

         for (int i = 0; i < sizeOfImaginaries; i++ )
         {
           int imaginaryOne = imaginaries.elementsList[i].imaginary1;
           int imaginaryTwo = imaginaries.elementsList[i].imaginary2;
            int imaginaryOutcome = imaginaries.elementsList[i].outcomeImaginary;
            int imaginaryResult = imaginaryOutcome - 1; //local var used to match imaginaryOutcome to toy indexes, basically to accomodate for zero based indexing
           
            // Debug.Log("imaginaryOne " + imaginaryOne + " imaginaryTwo" + imaginaryTwo);  print to make sure we are looping through all elements in list

            if (toyIndex1 == imaginaryOne) 
            {
                if (toyIndex2 == imaginaryTwo)
                {
                    Debug.Log("matches of " + imaginaryOne + "and" + imaginaryTwo); //check for matching pair
                    //Debug.Log("Imaginary Outcome Result: " + imaginaryOutcome );        //print out respective outcome number
                    Debug.Log("matching toy transform in Toy manager: " + toys[imaginaryResult]);   //print out imaginaryResult  to check if checking functions work
                    //Renderer imaginaryToy = toys[imaginaryResult].GetComponent<Renderer>();
                    //imaginaryToy.enabled = true; 
                    toys[imaginaryResult].gameObject.SetActive(true);

                    /*if (toys[imaginaryResult].gameObject.SetActive())
                   {
                       toys[imaginaryResult + 1].gameObject.SetActive(true);
                   }*/

                   /*if (toys[imaginaryResult].transform.GetChild(0).GetComponent<videoPlayer>() != null) 
                    {
                        videoPlay = toys[imaginaryResult].GetChild(0).GetComponent<videoPlayer>();
       
                        //Debug.log("has video:" + videoPlay);
                    } */

                }
            }
            
         }   

    }


    // Use this for initialization
    void Start()
    {   

        //children transforms of children toys under ToyManager
        //var childrenTransforms = toyManager.GetComponentInChildren<Transform>();
       

    }

    // Update is called once per frame
    void Update()
    {
      

    }

    
}
