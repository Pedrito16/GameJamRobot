using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSeguirPlayer : MonoBehaviour
{
    float speed = 10;
    public GameObject pointCam1;
    public Transform player1Transform;
    public Transform player2Transform;
    public Transform player3Transform;
    public GameObject pointCam2;
    public GameObject pointCam3;
    public Vector3 offset;
    public Player player;
    public Player2 player2;
    public HumanPlayer player3;
    // Start is called before the first frame update
    void Start()
    {
        pointCam1.SetActive(true);
        pointCam2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(player.hasBattery == true)
        {
            pointCam1.SetActive(true);
            pointCam2.SetActive(false);
            pointCam3.SetActive(true);
            Vector3 posicaoPlayer = player1Transform.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, posicaoPlayer, speed);
            pointCam1.transform.position = smoothedPosition;
            //transform.position = Vector3.Lerp(transform.position, new Vector3(pointCam1.transform.position.x, pointCam1.transform.position.y, transform.position.z), speed / 10);
        } else if (player.hasBattery == false && player2.hasBattery == true)
        {
            pointCam1.SetActive(false);
        }
        if(player2.hasBattery == true)
        {
            pointCam1.SetActive(false);
            pointCam2.SetActive (true);
            pointCam3.SetActive(true);
            Vector3 posicaoPlayer = player2Transform.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, posicaoPlayer, speed);
            pointCam2.transform.position = smoothedPosition;
            //transform.position = Vector3.Lerp(transform.position, new Vector3(pointCam2.transform.position.x, pointCam2.transform.position.y, transform.position.z), speed / 10);
        } else if(player2.hasBattery == false && player.hasBattery == true ) 
        {
            pointCam2.SetActive(false);
        
        }
        
        if(player3.hasBattery == true)
        {
            pointCam1.SetActive(false); //robo1
            pointCam2.SetActive(false); //robo2
            pointCam3.SetActive(true); //humano
            Vector3 posicaoPlayer = player3Transform.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, posicaoPlayer, speed);
            pointCam3.transform.position = smoothedPosition;
        }
            

        
    }
}
