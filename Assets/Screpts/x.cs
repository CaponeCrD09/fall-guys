using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class x : MonoBehaviour
{
    public float speed;
    public bool cil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

     if( transform.position.z <= -4 )
        {
            cil = false;
        }
        if( transform.position.z >= 4)
        {
            cil = true;
        }
        if( cil == true )
        {
            transform.Translate(0, 0 ,-(speed * Time.deltaTime) );
        }
        else
        {
            transform.Translate(0, 0 , speed * Time.deltaTime);
        }
    }
}
