using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboAzul : MonoBehaviour
{
    public float horizontal;
    public float speed = 5, jumpStrength = 5;
    Collider2D body;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        
    }
}
