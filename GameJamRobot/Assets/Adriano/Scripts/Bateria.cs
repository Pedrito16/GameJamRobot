using System.Collections;
using System.Collections.Generic;
using UnityEditor.TextCore.Text;
using UnityEngine;

public class Bateria : MonoBehaviour
{
    public float velocidadeRotacao = 150;
    public HumanPlayer player3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ParedeNormal"))
        {
            Destroy(gameObject);
            player3.GetComponent<HumanPlayer>().hasBattery = true;
        }
    }
    private void Update()
    {
        float quantidadeRotacao = velocidadeRotacao * Time.deltaTime;
          transform.Rotate(Vector3.forward, quantidadeRotacao);
    }
    private void OnBecameInvisible()
    {
       Destroy(gameObject);
    }
}
