using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float speed = 2;
    private float horizontal;
    public int direction;
    public GameObject bateria;
    public bool hasBattery = false;
    public float speedBattery = 5;
    public Transform Esquerda, Direita;
    public bool GroundCheck;
    Collider2D footCollision;
    Transform foot;
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (horizontal != 0)
        {
            direction = (int)horizontal;
        }
        
        if (CompareTag("Player2") && hasBattery == true)
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            playerRB.velocity = new Vector2(speed * horizontal, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightControl) && hasBattery == true)
        {
            if (direction == -1)
            { //trocar rotação quando exportar sprite
                GameObject bateriaClone = Instantiate(bateria, Esquerda.position, transform.rotation);
                bateriaClone.GetComponent<Rigidbody2D>().velocity = new Vector2(speedBattery * direction, 0);
            }
            else if (direction == 1)
            {
                GameObject bateriaClone = Instantiate(bateria, Direita.position, transform.rotation);
                bateriaClone.GetComponent<Rigidbody2D>().velocity = new Vector2(speedBattery * direction, 0);
            }

            hasBattery = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bateria"))
        {
            Destroy(collision.gameObject);
            hasBattery = true;
        }
    }
}
