using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstaculos : MonoBehaviour
{
    public GameObject obst; //O Obstáculo tomado como base
    public float altura; //Altura para variar a passagem da Nave
    public float maxTime; //Tempo limite entre a geração de um novo obstáculo

    private float timer = 0f; //Váriavel contadora de tempo

    // Start is called before the first frame update
    void Start()
    {
        //Gerando uma cópia do obstáculo referenciado
        GameObject newObst = Instantiate(obst);
        //Projetando na tela o novo obstáculo gerado
        newObst.transform.position = transform.position + new Vector3(0, Random.Range(-altura, altura), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Quando o tempo limite é atingido
        if(timer > maxTime){
            //É criado um novo obstáculo
            GameObject newObst = Instantiate(obst);
            //o obstáculo é apresentado na tela de jogo
            newObst.transform.position = transform.position + new Vector3(0, Random.Range(-altura, altura), 0);
            //Depois de 10 segundos este obstáculo é destruído
            Destroy(newObst, 10f);
            //A contagem de tempo é reiniciada
            timer = 0;
        }
        //O tempo é incrementado
        timer += Time.deltaTime;
    }
}
