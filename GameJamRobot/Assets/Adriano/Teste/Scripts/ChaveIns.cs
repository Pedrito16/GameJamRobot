using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaveIns : MonoBehaviour
{
    public GameObject key;
    public Transform keySpawn;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(key, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
