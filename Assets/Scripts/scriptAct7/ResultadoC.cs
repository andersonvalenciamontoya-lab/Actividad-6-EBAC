using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultadoC : MonoBehaviour
{
    public GameObject Cubo3;
    public GameObject Cubo;

    private MeshRenderer renderCubo;

    void Start()
    {
        renderCubo = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        bool valorA = Cubo.GetComponent<ResultadoA>().resultadoA;
        bool valorB = Cubo3.GetComponent<ResultadoB>().resultadoB;

        if (valorA || valorB)
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
