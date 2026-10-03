using UnityEngine;

public class AwakeColor : MonoBehaviour
{
    public GameObject Cubo;

    private void Awake()
    {
        GameObject tempGameObject = Cubo;

        Color c = new Color(Random.value, Random.value, Random.value);

        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}