using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpColor : MonoBehaviour
{
    public GameObject Esfera;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        GameObject tempGameObject = Esfera;

        Color c = new Color(Random.value, Random.value, Random.value);

        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
