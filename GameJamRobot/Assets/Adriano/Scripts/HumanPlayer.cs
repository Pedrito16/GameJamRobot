using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanPlayer : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float speed;
    private float horizontal;
    public int direction;
    public bool hasBattery;
    public GameObject bateria;
    public Transform Esquerda, Direita;
    public int speedBattery = 4;
    public bool GroundCheck;
    Collider2D footCollision;
    Transform foot;
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {
        if(horizontal != 0)
        {
            direction = (int)horizontal;
        }
        horizontal = Input.GetAxisRaw("HorizontalDois");
        playerRB.velocity = new Vector2(speed * horizontal, 0);
        if (Input.GetButtonDown("FireHuman") && hasBattery == true)
        {
            if (direction == -1)
            {
                GameObject bateriaClone = Instantiate(bateria, Esquerda.position, transform.rotation);
                bateriaClone.GetComponent<Rigidbody2D>().velocity = new Vector2(speedBattery * direction, 0);
                
            }
            else if (direction == 1)
            { //mudar a rota��o depois quando for exportar o sprite
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
