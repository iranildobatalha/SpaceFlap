using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public float velocidade; //Velocidade com a qual os obstáculos se aproximam

    // Update is called once per frame
    void Update()
    {
        //A cada segundo de tempo o objeto se desloca para a esquerda com uma certa velocidade
        transform.position += Vector3.left * velocidade * Time.deltaTime;
    }
}
