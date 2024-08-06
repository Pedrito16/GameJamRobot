using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject Menu;
    public bool Ativador;
    void Start()
    {
        Menu.SetActive(false);
        Ativador = false;
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Cancel") && Ativador == false)
        {
            Menu.SetActive(true);
            Ativador = true;
        } else if(Input.GetButtonDown("Cancel") && Ativador == true)
        {
            Menu.SetActive(false);
            Ativador = false;
        }
            
        
    }
}
