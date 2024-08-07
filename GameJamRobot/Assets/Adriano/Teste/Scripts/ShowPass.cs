using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class ShowPass : MonoBehaviour
{
    [SerializeField]
    public GameObject number;
    public GameObject notshowable;
    public GameObject notshowable2;
    public GameObject dark;
    public Camera camPlayerD;
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
        if(collision.CompareTag("Player"))
        {
            number.SetActive(true);
            dark.SetActive(true);
            notshowable.SetActive(false);
            notshowable2.SetActive(false);
            camPlayerD.orthographicSize = 20;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        number.SetActive(false);
        dark.SetActive(false);
        notshowable.SetActive(true);
        notshowable2.SetActive(true);
        camPlayerD.orthographicSize = 5;
    }
}
