using System.Collections;
using System.Collections.Generic;
using UnityEditor.TextCore.Text;
using UnityEngine;

public class Bateria : MonoBehaviour
{
    [Header("Scripts de referençia para recuperar bateria")]
    public Player player;
    public Player2 player2;
    public HumanPlayer player3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ParedeNormal"))
        {
            Destroy(gameObject);

        }
    }
    private void OnBecameInvisible()
    {
       Destroy(gameObject);
    }
}
