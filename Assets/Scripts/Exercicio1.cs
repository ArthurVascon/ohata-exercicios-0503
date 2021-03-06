using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube;
    public Transform[] startPosition;
    public Transform[] endPosition;
    public GameObject target;
    public float speed;
    public Material[] materials;
    public int index = 0;
    // Start is called before the first frame update
    private void Start()
    {
        sphere.transform.position = startPosition[0].transform.position;
        cube.transform.position = startPosition[1].transform.position;
    }
    void Update()
    {
        Exercicio2();
    }

    // Update is called once per frame

    void Exercicio2()
    {
        sphere.GetComponent<MeshRenderer>().material = materials[1];
        
        cube.gameObject.SetActive(true);
        cube.GetComponent<MeshRenderer>().material = materials[1];
        sphere.transform.position = Vector3.MoveTowards(sphere.transform.localPosition, endPosition[0].position, speed * Time.deltaTime);
        cube.transform.position = Vector3.MoveTowards(cube.transform.localPosition, endPosition[0].position, speed * Time.deltaTime);
    }
   
}
