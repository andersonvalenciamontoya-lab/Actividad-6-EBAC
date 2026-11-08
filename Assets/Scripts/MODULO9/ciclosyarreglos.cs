using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ciclosyarreglos : MonoBehaviour

{ 
    void Start()
    {
        
        // EJERCICIO 1: ARREGLOS
        

        int[] arr1 = new int[5];
        int[] arr2 = new int[5];
        int[] arr3 = new int[5];

        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = Random.Range(1, 11);
            arr2[i] = Random.Range(1, 11);

            arr3[i] = arr1[i] + arr2[i];

            Debug.Log("Arr1: " + arr1[i] +
                      " | Arr2: " + arr2[i] +
                      " | Suma: " + arr3[i]);
        }


        
        // EJERCICIO 2: FOREACH
        

        string[] palabras = new string[5];

        palabras[0] = "EBAC";
        palabras[1] = "es";
        palabras[2] = "una";
        palabras[3] = "gran";
        palabras[4] = "escuela";

        string oracion = "";

        foreach (string palabra in palabras)
        {
            oracion += palabra + " ";
        }

        Debug.Log(oracion);


        
        // EJERCICIO 3: MATRICES
        

        int[,] matriz = new int[2, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        int[] vector = { 2, 3, 4 };

        int[] resultado = new int[2];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            resultado[i] = 0;

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                resultado[i] += matriz[i, j] * vector[j];
            }

            Debug.Log("Resultado fila " + i + ": " + resultado[i]);
        }
    }
}
