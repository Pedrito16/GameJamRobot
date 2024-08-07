using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevador : MonoBehaviour
{
    public GameObject playerElevator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Chave.chave == true)
        {
            playerElevator.transform.forward = new Vector2(playerElevator.transform.position.x, playerElevator.transform.position.y - 10);
        }
    }
}
