using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class desaparecer : MonoBehaviour
{
    bool ativado = true;

    int estado = 0; //0 = branco solido, 1 = vermelho, 3 = desaparece;

    void Start()
    {
        StartCoroutine(desativar());
        
       
    }


    void Update()
    {

    }
    
    IEnumerator desativar()
    {
        ativado = !ativado;
        GetComponent<Renderer>().enabled = ativado;
        GetComponent<BoxCollider>().enabled = ativado;

        float segundos = Random.Range(3,5);

        yield return new WaitForSeconds(segundos);
        StartCoroutine(desativar());
        
        
    }




}
