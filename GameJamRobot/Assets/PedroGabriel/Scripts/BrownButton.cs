using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownButton : MonoBehaviour
{
    public Animator animator;
    public Transform outputBox;
    public GameObject box;
    public bool boxSpawned = false;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && boxSpawned == false || collision.CompareTag("Player2") && boxSpawned == false || collision.CompareTag("Human") && boxSpawned == false)
        {
            animator.SetBool("Pressed", true);
            Instantiate(box, outputBox.position, outputBox.rotation);
            boxSpawned = true;
        }
    }
}
