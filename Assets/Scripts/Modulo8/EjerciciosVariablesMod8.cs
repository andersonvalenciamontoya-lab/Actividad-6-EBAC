
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
   
    public GameObject Cubo5;
    public GameObject Cubo6;

  
    public int contador = 0;
    public float multiplicador = 2f;
    public float numeroA = 5.5f;
    public float numeroB = 2f;
    public int numeroParImpar = 7;
    public string palabraColor = "rojo";
    public float numeroDecimal = 3.141592f;
    public string nombreCompleto = "Anderson Valencia Montoya";
    public string valorTextoA = "1200";
    public string valorTextoB = "3500";
    public string oracion = "Hola Mundo";
    public string oracionEliminar = "Hola Mundo desde EBAC";

    void Start()
    {
        // operacion entre floats y casteo explicito
        int resultadoEntero = (int)(numeroA / numeroB);
        Debug.Log(" Resultado entero: " + resultadoEntero);

        // switch para cambiar el color
        Renderer rendererCubo = Cubo6.GetComponent<Renderer>();

        switch (palabraColor.ToLower())
        {
            case "rojo":
                rendererCubo.material.color = Color.red;
                break;

            case "azul":
                rendererCubo.material.color = Color.blue;
                break;

            case "verde":
                rendererCubo.material.color = Color.green;
                break;

            default:
                rendererCubo.material.color = Color.white;
                break;
        }

        //  float a string con 4 decimales
        string numeroFormateado = numeroDecimal.ToString("F4");
        Debug.Log("Numero: " + numeroFormateado);

        //  separar nombre usando Substring
        int primerEspacio = nombreCompleto.IndexOf(' ');
        int segundoEspacio = nombreCompleto.IndexOf(' ', primerEspacio + 1);

        string nombre = nombreCompleto.Substring(0, primerEspacio);
        string apellido1 = nombreCompleto.Substring(
            primerEspacio + 1,
            segundoEspacio - primerEspacio - 1
        );
        string apellido2 = nombreCompleto.Substring(segundoEspacio + 1);

        Debug.Log("Nombre: " + nombre);
        Debug.Log("Primer apellido: " + apellido1);
        Debug.Log("Segundo apellido: " + apellido2);

        //  separar nombre usando Split
        string[] partesNombre = nombreCompleto.Split(' ');

        foreach (string parte in partesNombre)
        {
            Debug.Log("Split: " + parte);
        }

        //  convertir string a numero con TryParse
        if (int.TryParse(valorTextoA, out int valorA) &&
            int.TryParse(valorTextoB, out int valorB))
        {
            int suma = valorA + valorB;
            Debug.Log(" Suma: " + suma);
        }
        else
        {
            Debug.Log("No se pudieron convertir los valores.");
        }

        //  imprimir caracteres en indices pares
        Debug.Log(" Caracteres:");

        for (int i = 0; i < oracion.Length; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(oracion[i]);
            }
        }

        //  eliminar los primeros 5 caracteres
        string textoRecortado = oracionEliminar.Substring(5);
        Debug.Log(" Texto: " + textoRecortado);
    }

    void Update()
    {
        //  incrementar un entero en cada frame
        contador++;
        Debug.Log("la suma es:" + contador);
    }

    void FixedUpdate()
    {
        //  multiplicar el float en cada FixedUpdate
        multiplicador *= 1.01f;
        Debug.Log("la multiplicacion es:" + multiplicador);

        //  cambiar el color segun sea par o impar
        if (Cubo5 != null)
        {
            Renderer rendererCubo = Cubo5.GetComponent<Renderer>();

            if (rendererCubo != null)
            {
                if (numeroParImpar % 2 == 0)
                {
                    rendererCubo.material.color = Color.blue;
                }
                else
                {
                    rendererCubo.material.color = Color.red;
                }
            }
        }
    }
}
