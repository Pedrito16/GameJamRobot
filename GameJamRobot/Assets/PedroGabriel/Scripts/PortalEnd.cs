using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PortalEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Human") && collision.GetComponent<HumanPlayer>().hasKey == true)
        {
            SceneManager.LoadScene("FinalContext");

        }
    }
}
