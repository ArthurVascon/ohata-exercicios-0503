using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio : MonoBehaviour
{
    public GameObject sphere;
    public Transform[] endPosition;
    public float speed;
    public Material[] materials;
    
    void Update()
    {

        Exercicio1();
    }

   // Exercício 1 - Fazer o objeto se mover até o ponto
    void Exercicio1()
    {
        //Troca o material do objeto pra representar o exercício
        sphere.GetComponent<MeshRenderer>().material = materials[0];
        // Faz com que a posição do objeta seja o mesmo da posição final que foi colocado de objeto
        transform.position = Vector3.MoveTowards(transform.position, endPosition[0].transform.position, speed * Time.deltaTime);
    }
}
