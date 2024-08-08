using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    public Animator animator;
    
    public GameObject finalDoor;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Player2") || collision.CompareTag("Human"))
        {
            animator.SetBool("Apertado", true);
            finalDoor.SetActive(false);
            
        }
    
    }
}
