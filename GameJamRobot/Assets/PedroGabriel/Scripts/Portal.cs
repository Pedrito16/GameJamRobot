using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    //o código vai colocado em um gameObject invisivel que terá BoxCollider2D trigger
    public Transform teleportLocation1, teleportLocation2, HumanTeleportLocation;
    public Transform player1, player2, Human;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Human"))
        {
            Human.position = new Vector2(Human.position.x, Human.position.y - 8);
        }
    }
}
