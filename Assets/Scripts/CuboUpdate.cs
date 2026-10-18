using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboUpdate : MonoBehaviour
{
    public GameObject Cubo;
    void Update()
    {
        Instantiate(Cubo);
    }
}

