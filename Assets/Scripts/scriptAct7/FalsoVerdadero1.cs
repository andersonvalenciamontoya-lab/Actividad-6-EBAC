using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalsoVerdadero1 : MonoBehaviour
{
    public bool variable1;
    public GameObject Cubo;
    private void Awake()
    {
        
    }
    void Start()
    {
        if (variable1 == true)
        {
            variable1 = false;

        }
        else if (variable1 == false)

        {
            variable1 = true;
        }
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //if (variable1 == true)
        //{
          //  variable1 = false;

        //}
         //else if (variable1 == false)
            
        //{
          //  variable1 = true;
        //}

        if (!variable1)
        {
           
            GameObject tempGameObject = Cubo;
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            Debug.Log("Es Falso, por lo tanto es verdadero");
        }
        if (variable1)
        {

            GameObject tempGameObject = Cubo;
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.black;
            Debug.Log("es verdadero, por ende es falso");
        }
        

    }
}
