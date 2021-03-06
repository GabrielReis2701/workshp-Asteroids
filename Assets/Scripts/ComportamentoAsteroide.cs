using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoAsteroide : MonoBehaviour
{
    public Rigidbody2D meuRigidbody;
    public float velocidadeMaxima = 1.0f;
    public ComportamentoPedacoAsteroide prefabPedacoAsteroide;
    void Start()
    {
        Vector2 direcao = Random.insideUnitCircle;
        direcao *= velocidadeMaxima;
        meuRigidbody.velocity = direcao;
    }

    void OnTriggerEnter2D(Collider2D outro){
        float t = 0.1f;
        Destroy(gameObject,t);
        Instantiate(prefabPedacoAsteroide,meuRigidbody.position, Quaternion.identity);
        Destroy(outro.gameObject);

    }
}
