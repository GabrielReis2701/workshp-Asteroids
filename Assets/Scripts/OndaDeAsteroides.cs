using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OndaDeAsteroides : MonoBehaviour
{
    public ComportamentoAsteroide prefabAsteroide;
    public int quantAsteroides= 3;
    void Start()
    {
        for(int i=0;i<quantAsteroides;i++){
            float x = Random.Range(-9.0f, 9.0f);
            float y = Random.Range(-3.5f, 3.5f);
            Vector3 posicao = new Vector3(x, y, 0.0f);
            Instantiate(prefabAsteroide, posicao, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
