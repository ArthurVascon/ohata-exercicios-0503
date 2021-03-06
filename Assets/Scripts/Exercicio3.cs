using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    public GameObject sphere;
    public Transform[] startPosition;
    public Transform[] endPosition;
    public float speed;
    public Material[] materials;
    public int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        sphere.GetComponent<MeshRenderer>().material = materials[3];
    }
    
    void Update()
    {
        if (sphere.transform.position != endPosition[index].position)
        {
            sphere.transform.position = Vector3.MoveTowards(sphere.transform.localPosition, endPosition[index].position, speed * Time.deltaTime);
        } else
        {
            if(index == 4)
            {
                index = 0;
            } else
            {
                index++;
            }
        }
    }

    // Update is called once per frame

   
}
