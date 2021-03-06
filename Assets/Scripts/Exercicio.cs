using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio : MonoBehaviour
{
    public GameObject sphere;
    public Transform[] endPosition;
    public float speed;
    public Material[] materials;
    // Start is called before the first frame update
    void Update()
    {

        Exercicio1();
    }

    // Update is called once per frame
    void Exercicio1()
    {
        sphere.GetComponent<MeshRenderer>().material = materials[0];
        transform.position = Vector3.MoveTowards(transform.position, endPosition[0].transform.position, speed * Time.deltaTime);
    }
}
