using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bateria : MonoBehaviour
{
    public GameObject bateria;
    // Start is called before the first frame update
    void Start()
    {
        bateria = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.playerBateria == false)
        {
            ativarbateria();
        }
    }
    void ativarbateria()
    {
        bateria.SetActive (true);
    }
}
