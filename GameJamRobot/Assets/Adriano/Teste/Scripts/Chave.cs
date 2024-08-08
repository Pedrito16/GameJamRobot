using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chave : MonoBehaviour
{
    public static int chavecontador = 0;
    public GameObject key;
    public static bool chave = false;
    public Transform keySpawn;
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
        if(collision.CompareTag("Human"))
        {
            collision.gameObject.GetComponent<HumanPlayer>().hasKey = true;
            Destroy(key);
            chave = true;
            chavecontador = chavecontador + 1;
            if(chavecontador == 1 && chave == true)
            {
                Instantiate(key, new Vector3(-34, -30.64f, 0), Quaternion.identity);
            }
            else if (chavecontador == 2 && chave == true)
            {
                Instantiate(key, new Vector3(-34, -55, 0), Quaternion.identity);
            }
        }
    }
}
