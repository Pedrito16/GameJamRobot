using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public Rigidbody2D playerRB2;
    public float speed;
    private float direction;
    public bool currentplayer = true;
    public bool playerBateria = true;

    // Start is called before the first frame update
    void Start()
    {
        if(CompareTag("Player"))
        {
            playerRB = GetComponent<Rigidbody2D>();
        }
        if(CompareTag("Player2"))
        {
            playerRB2 = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(currentplayer == true) 
        {
            playerone();
        }
        else if (currentplayer == false) { playertwo(); }

        changePlayer();
       
    }

    void playerone()
    {
        if(CompareTag("Player") && playerBateria == true)
        {
            direction = Input.GetAxisRaw("Horizontal");
            playerRB.velocity = new Vector2(speed * direction, 0);
        }
    }

    void playertwo()
    {
        if(CompareTag("Player2") && playerBateria == true)
        {
            direction = Input.GetAxisRaw("Horizontal");
            playerRB2.velocity = new Vector2(speed * direction, 0);
        }
    }

    public void changePlayer()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            playerBateria = false;
            if (currentplayer)
            {
                currentplayer = false;
            }
            else { currentplayer = true; }
        }
    }

}
