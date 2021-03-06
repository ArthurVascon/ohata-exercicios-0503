using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube;
    public Transform[] startPosition;
    public Transform[] endPosition;
    public GameObject target;
    public float speed;
    public float speed1;
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

        Exercicio3();
    }

    // Update is called once per frame
    
    void Exercicio3()
    {
        sphere.GetComponent<MeshRenderer>().material = materials[2];
        cube.GetComponent<MeshRenderer>().material = materials[2];
        cube.gameObject.SetActive(true);
        sphere.transform.position = Vector3.MoveTowards(sphere.transform.position, target.transform.position, speed * Time.deltaTime);
        cube.transform.position = Vector3.MoveTowards(cube.transform.position, target.transform.position, speed * Time.deltaTime);
        target.transform.position = Vector3.MoveTowards(target.transform.position, endPosition[1].position, speed1 * Time.deltaTime);
    }
    
}
