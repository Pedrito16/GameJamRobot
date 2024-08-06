using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public GameObject Menu;
    public bool Ativador;
    string activeScene;
    void Start()
    {
        Menu.SetActive(false);
        Ativador = false;
        activeScene = SceneManager.GetActiveScene().name;
    }
    public void Resume()
    {
        Time.timeScale = 1;
    }
    public void Restart()
    {
        SceneManager.LoadScene(activeScene);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1;
    }
    void Update()
    {
        if (Input.GetButtonDown("Cancel") && Ativador == false)
        {
            Menu.SetActive(true);
            Time.timeScale = 0;
            Ativador = true;
        } else if(Input.GetButtonDown("Cancel") && Ativador == true)
        {
            Menu.SetActive(false);
            Time.timeScale = 1;
            Ativador = false;
        }
    }
}
