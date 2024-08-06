using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bateriacodigo : MonoBehaviour
{
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        player.playerRB.position = this.transform.position;
    }
}
