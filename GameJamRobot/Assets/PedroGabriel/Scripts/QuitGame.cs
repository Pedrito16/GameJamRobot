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
    
    public void Jogar()
    {
        SceneManager.LoadScene("Test");
    }
    public void CarregarCena()
    {
        SceneManager.LoadScene("InicioContext");
    }
    public void SairJogo()
    {
        Application.Quit();

    }
    public void irMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
