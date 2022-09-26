using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    //Teletransporta al jugador a el transportador seleccionado
    public void tele()
    {
        player.transform.position = new Vector3(transform.position.x, transform.position.y+1.6f, transform.position.z);
    }
}
