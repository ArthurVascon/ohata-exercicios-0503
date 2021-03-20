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
        //Material do exercício
        sphere.GetComponent<MeshRenderer>().material = materials[3];
    }
    
    void Update()
    {
        //Se a posição do objeto não for igual ao da posição
        if (sphere.transform.position != endPosition[index].position)
        {
            //Move o objeto para a posição
            sphere.transform.position = Vector3.MoveTowards(sphere.transform.localPosition, endPosition[index].position, speed * Time.deltaTime);
        } else
        {
            //Se for o último ponto
            if(index == 4)
            {
                //Muda o Index pro primeiro ponto
                index = 0;
            } else
            {
                //Senão, aumenta o index
                index++;
            }
        }
    }

    // Update is called once per frame

   
}
