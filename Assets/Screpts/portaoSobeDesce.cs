using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portaoSobeDesce : MonoBehaviour
{
    public float speed = 0.3f;
    public float stopTime = 1.0f;

    public bool up = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        Vector3 posicao_poertao = transform.position;


        
        if( transform.position.y >= 2 )
        {
            up = false;
        }
        if( transform.position.y <= -2)
        {
            up = true;
        }
        if( up == true )
        {
            transform.Translate(0, speed * Time.deltaTime, 0 );
        }
        else
        {
            transform.Translate(0, -(speed * Time.deltaTime), 0);
        }

    }
}
