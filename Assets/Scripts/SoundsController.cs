using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsController : MonoBehaviour
{
    //Recebendo os sons que serão usados nos movimentos do Jogo
    public AudioSource pulo;
    public AudioSource gameover;

    //Função que toca o som do pulo da Nave
    public void Pular()
    {
        pulo.Play();
    }

    //Função que toca o som de GameOver
    public void FimDeJogo()
    {
        gameover.Play();
    }
}
