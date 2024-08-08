using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Animator animator;
    public GameObject Door;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") || collision.CompareTag("Player2") || collision.CompareTag("Human"))
        {
            animator.SetBool("IsPressing", true);
            Door.SetActive(false);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Player2") || collision.CompareTag("Human"))
        {
            animator.SetBool("IsPressing", true);
            Door.SetActive(false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Player2") || collision.CompareTag("Human"))
        {
            animator.SetBool("IsPressing", false);
            Door.SetActive(true);
        }
    }
}
