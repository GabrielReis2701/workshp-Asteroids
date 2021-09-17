using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoAsteroide : MonoBehaviour
{
    public Rigidbody2D meuRigidbody;
    public float velocidadeMaxima = 1.0f;
    void Start()
    {
        Vector2 direcao = Random.insideUnitCircle;
        direcao *= velocidadeMaxima;
        meuRigidbody.velocity = direcao;
    }

    void OnTriggerEnter2D(Collider2D outro){
        float t = 0.1f;
        Destroy(gameObject,t);
        Destroy(outro.gameObject);

    }
}
