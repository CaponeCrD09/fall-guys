using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Municao : MonoBehaviour
{
     float time = Random.Range(2f, 10f);

     public GameObject objeto;
    // Start is called before the first frame update
    void Start()
    {
        
         StartCoroutine(gerador());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator gerador()
    {
        Instantiate(objeto,transform.position, Quaternion.identity);
        yield return new WaitForSeconds(time);
         StartCoroutine(gerador());
    }
}
