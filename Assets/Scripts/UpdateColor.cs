using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateColor : MonoBehaviour
{
    public GameObject Capsula;

    // Update is called once per frame
    void Update()
    {
        GameObject tempGameObject = Capsula;

        Color c = new Color(Random.value, Random.value, Random.value);

        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
