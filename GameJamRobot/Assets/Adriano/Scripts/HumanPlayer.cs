using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanPlayer : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float speed;
    private float horizontal;
    public int direction = -1;
    public bool hasBattery;
    public GameObject bateria;
    public Transform Esquerda, Direita;
    public int speedBattery = 7;
    public bool GroundCheck;
    Collider2D footCollision;
    Vector3 esquerda, direita, camTransformInitial;
    public Transform foot;
    public float jumpStrength = 3;
    public Transform camTransform;
    public bool hasKey = false;
    public GameObject batteryFrame;
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        esquerda = Esquerda.position - transform.position;
        direita = Direita.position - transform.position;
        
    }

    
    void Update()
    {
        Vector2 scale = transform.localScale;
        scale.x = direction;
        if(direction == -1 )
        {
            scale.x = -0.5f;
        } else if(direction == 1 ) 
        {
            scale.x = 0.5f;
        }
        transform.localScale = scale;


        Esquerda.position = transform.position + esquerda;
        Direita.position = transform.position + direita;

        batteryFrame.SetActive(hasBattery);
        
        footCollision = Physics2D.OverlapCircle(foot.position, 0.05f);
        GroundCheck = footCollision;
        if(horizontal != 0)
        {
            direction = (int)horizontal;
        }
        horizontal = Input.GetAxisRaw("HorizontalDois");
        playerRB.velocity = new Vector2(speed * horizontal, playerRB.velocity.y );
        if (Input.GetButtonDown("VerticalDois") && GroundCheck)
        {
            playerRB.AddForce(new Vector2(0, jumpStrength * 100));

        }
        if (Input.GetButtonDown("FireHuman") && hasBattery == true)
        {
            if (direction == -1)
            {
                GameObject bateriaClone = Instantiate(bateria, Esquerda.position, transform.rotation);
                bateriaClone.GetComponent<Rigidbody2D>().velocity = new Vector2(speedBattery * direction, 0);
                
            }
            else if (direction == 1)
            { //mudar a rotação depois quando for exportar o sprite
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
        if (collision.CompareTag("Key"))
        {

            Destroy(collision.gameObject);
            hasKey = true;
        }
    }
}
