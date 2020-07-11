using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontuacao : MonoBehaviour
{
    //Obtendo a classe de controle do Jogo
    public GameController controller;

    void Start(){
        //Inicializando a variável e obtendo o valor da pontuação até então
        controller = FindObjectOfType<GameController>();
    }

    //Evento disparado quando a Nave passa entre os obstáculos
    void OnTriggerEnter2D(Collider2D colisor){
        //Incrementando a pontuação
        controller.Score++;
        //Alterando o valor da pontuação na tela
        controller.scoreText.text = controller.Score.ToString();
    }
}
