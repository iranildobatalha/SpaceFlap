using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 1f; //Força com que a Nave pula
    private Rigidbody2D rigi; //Componente que dá Física ao objeto

    public GameObject GameOver; //Canvas que mostra a mensagem de GameOver
    public SoundsController sounds; //Classe que gerencia os sons da tela de Jogo

    // Start is called before the first frame update
    void Start()
    {
        //Obtendo as propriedades do Objeto referenciado
        rigi = GetComponent<Rigidbody2D>();
        //Obtendo os sons da tela de Jogo
        sounds = FindObjectOfType<SoundsController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Quando o usuário clica na tela
        if(Input.GetMouseButtonDown(0)){
            //A Nave pula pra cima
            rigi.velocity = Vector2.up * velocidade;
            //E dispara o som de pulo
            sounds.Pular();
        }
    }

    //Evento disparado quando a Nave toca em um obstáculo ou cai
    void OnCollisionEnter2D(Collision2D colisor){
        //A mensagem de Game Over é disparada na tela
        GameOver.SetActive(true);
        //O jogo é pausado
        Time.timeScale = 0;
        //O som de Game Over também é disparado
        sounds.FimDeJogo();
    }
}
