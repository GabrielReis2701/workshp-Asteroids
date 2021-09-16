using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacao : MonoBehaviour
{
    public float velocidade = 10.0f;
    public float velocidade1 = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("movendo o quadrado");
    }

    // Update is called once per frame
    void Update()
    {
        //Ao apertar a letra D o quadrado se move para a direita
        if(Input.GetKey(KeyCode.D)){
           transform.position += new Vector3(velocidade * Time.deltaTime, 0.0f, 0.0f);
        }
        //Ao apertar a letra A o quadrado se move para a esquerda
        if(Input.GetKey(KeyCode.A)){
           transform.position += new Vector3(velocidade1 * Time.deltaTime, 0.0f, 0.0f);
           
        }
        //Ao apertar a letra W o quadrado se move para a cima
        if(Input.GetKey(KeyCode.W)){
           transform.position += new Vector3(0.0f, velocidade * Time.deltaTime, 0.0f); 
        }
        //Ao apertar a letra S o quadrado se move para a baixo
        if(Input.GetKey(KeyCode.S)){
           transform.position += new Vector3(0.0f, velocidade1 * Time.deltaTime, 0.0f);
           
        }
        
    }
}
