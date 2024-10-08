using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D playerRB;
    
    public float speed;
    private float horizontal;
    public int direction = -1;
    public GameObject bateria;
    public bool hasBattery;
    public bool hasKey = false;
    public float speedBattery = 7;
    public Transform Esquerda, Direita;
    public bool GroundCheck;
    Collider2D footCollision;
    public Transform foot;
    public float jumpStrength = 3;
    public Animator animator;
    public GameObject batteryFrame;
    // Start is called before the first frame update
    void Start()
    {
        if(CompareTag("Player"))
        {
            playerRB = GetComponent<Rigidbody2D>();
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Desligar", hasBattery);
        footCollision = Physics2D.OverlapCircle(foot.position, 0.05f);
        GroundCheck = footCollision;
        
        if(horizontal != 0)
        {
            direction = (int)horizontal;
        }
        if (CompareTag("Player") && hasBattery == true)
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            animator.SetFloat("Speed", horizontal);
            playerRB.velocity = new Vector2(speed * horizontal, playerRB.velocity.y);
            
        }
        batteryFrame.SetActive(hasBattery);
        if(Input.GetButtonDown("Vertical") && GroundCheck && hasBattery == true)
        {
            playerRB.AddForce(new Vector2(0, jumpStrength * 100));

        }
        if(Input.GetKeyDown(KeyCode.RightControl) && hasBattery == true)
        {
            if (direction == -1)
            { //trocar rota��o quando exportar sprite
                GameObject bateriaClone = Instantiate(bateria, Esquerda.position, transform.rotation);
                bateriaClone.GetComponent<Rigidbody2D>().velocity = new Vector2(speedBattery * direction, 0);
                
            } else if(direction == 1)
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
        if (collision.CompareTag("Key"))
        {

            Destroy(collision.gameObject);
            hasKey = true;
        }
    }
    /*bateriaClone.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    bateriaClone.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,0));*/
}
