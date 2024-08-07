using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTest : MonoBehaviour
{
    public Transform pointCam;
    float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(pointCam.position.x, pointCam.position.y, transform.position.z), speed / 10);
    }
}
