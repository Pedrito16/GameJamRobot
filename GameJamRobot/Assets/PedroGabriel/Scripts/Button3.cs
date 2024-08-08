using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button3 : MonoBehaviour
{
    public Animator animator;
    public GameObject Door;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Player2") || collision.CompareTag("Human") || collision.CompareTag("Caixa"))
        {
            animator.SetBool("Apertado", true);
            Door.SetActive(false);

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Player2") || collision.CompareTag("Human") || collision.CompareTag("Caixa"))
        {
            animator.SetBool("Apertado", true);
            Door.SetActive(false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Player2") || collision.CompareTag("Human") || collision.CompareTag("Caixa"))
        {
            animator.SetBool("Apertado", false);
            Door.SetActive(true);
        }
    }
}
