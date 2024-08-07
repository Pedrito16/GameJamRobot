using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chave : MonoBehaviour
{
    public GameObject key;
    public static bool chave = false;
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
        Destroy(key);
        chave = true;
    }
}
