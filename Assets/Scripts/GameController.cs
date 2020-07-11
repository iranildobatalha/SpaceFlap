using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int Score; //Vaiável que guarda a pontuação atual do jogador
    public Text scoreText; //O texto na tela com a pontuaçao do jogador

    void Start(){
        //Despauzando a Cena
        Time.timeScale = 1;
    }

    //Reiniciando o Jogo
    public void RestartGame(){
        SceneManager.LoadScene(1);
    }

    //Voltando ao Menu Principal
    public void GoToMenu()
    {
        SceneManager.LoadScene("Inicio");
    }

    //Iniciando o Jogo
    public void StartGame()
    {
        SceneManager.LoadScene("Joguinho");
    }

    /*public void Exit()
    {
        Aplication.Quite();
    }*/
}
