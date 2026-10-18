using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalsoVerdadero : MonoBehaviour
{
    public bool variable;
    public GameObject Cubo;
    private void Awake()
    {
        
    }
    void Start()
    {
        if (variable == true)
        {
            variable = false;

        }
        else if (variable == false)

        {
            variable = true;
        }
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        

        if (!variable)
        {

            GameObject tempGameObject = Cubo;
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            Debug.Log("Es Falso, por lo tanto es verdadero");
        }
        if (variable)
        {

            GameObject tempGameObject = Cubo;
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.black;
            Debug.Log("es verdadero, por ende es falso");
        }


    }
}
