using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using Cinemachine;

public class ShowPass : MonoBehaviour
{
    [SerializeField]
    public GameObject number;
    public GameObject numberBG;
    public GameObject notshowable;
    public GameObject notshowable2;
    public GameObject dark;
    public CinemachineVirtualCamera humanCam;
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
            numberBG.SetActive(true);
            number.SetActive(true);
            dark.SetActive(true);
            notshowable.SetActive(false);
            notshowable2.SetActive(false);
            humanCam.m_Lens.OrthographicSize = 40;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        numberBG.SetActive(false);
        number.SetActive(false);
        dark.SetActive(false);
        notshowable.SetActive(true);
        notshowable2.SetActive(true);
        humanCam.m_Lens.OrthographicSize = 13.5f;
    }
}
