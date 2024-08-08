using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bateria : MonoBehaviour
{
    public float velocidadeRotacao = 150;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ParedeNormal"))
        {
            Destroy(gameObject);
            
        }
    }
    private void Update()
    {
        float quantidadeRotacao = velocidadeRotacao * Time.deltaTime;
          transform.Rotate(Vector3.forward, quantidadeRotacao);
    }
    
}
