using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    
    
    void Start()
    {
        
    }   

    
    void Update()
    {
       
    }
    
    
    public void CarregarCena()
    {
        SceneManager.LoadScene("Game");
    }
    public void SairJogo()
    {
        Application.Quit();

    }
}
