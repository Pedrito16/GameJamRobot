using System.Collections;
using System.Collections.Generic;
using UnityEditor.TextCore.Text;
using UnityEngine;

public class Bateria : MonoBehaviour
{
    public GameObject bateriaprefab;
    public int bateriaqt = 1;
    public GameObject spawn;
    public float force;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && bateriaqt == 1)
        {
            Instantiate(bateriaprefab, spawn.transform.position, spawn.transform.rotation);
        }
    }
}
