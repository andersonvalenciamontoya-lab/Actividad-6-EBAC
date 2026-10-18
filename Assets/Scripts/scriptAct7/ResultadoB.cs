using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultadoB : MonoBehaviour
{

    public GameObject Cubo1;
    public GameObject Cubo2;
    public bool resultadoB;
    private MeshRenderer renderCubo;

    void Start()
    {
        renderCubo = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        bool valor1 = Cubo1.GetComponent<FalsoVerdadero>().variable;
        bool valor2 = Cubo2.GetComponent<FalsoVerdadero1>().variable1;
        resultadoB = valor1 || valor2;
        if (valor1 || valor2)
        {
            renderCubo.material.color = Color.white;
            Debug.Log("verdadero");
        }
        else
        {
            renderCubo.material.color = Color.black;
            Debug.Log("falso");
        }
    }
}

