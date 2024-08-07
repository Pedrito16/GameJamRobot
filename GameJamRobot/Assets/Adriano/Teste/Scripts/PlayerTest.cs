using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float speed;
    private float direction;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }
    public void movement()
    {
        direction = Input.GetAxisRaw("Horizontal");
        playerRB.velocity = new Vector2(speed * direction, 0);
    }
}
