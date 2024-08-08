using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teletransporte : MonoBehaviour
{
    public Transform player;
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
        if(Chave.chave == true)
        {
            player.position = new Vector2(player.position.x, player.position.y - 25);
            Chave.chave = false;
        }

        
        else if(Chave.chave == true && Chave.chavecontador == 3)
        {
            SceneManager.LoadScene("");
        }
    }
}
