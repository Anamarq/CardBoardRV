using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Open4 : MonoBehaviour
{

    private GameObject player;
    public GameObject light1;
    public GameObject light2;
    public GameObject linterna;
    public GameObject door4;
    public AudioSource darkMusic;
    public GameObject sound;
    private bool rep = true;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        darkMusic.Stop();

    }

    public void Dark()
    {
        //Apaga luces, cambia audio si se entra en la habitación
        if ((player.transform.position.z > 5) && (player.transform.position.x > -4))
        {
            if (rep)
            {
                light1.SetActive(false);
                light2.SetActive(false);
                sound.SetActive(false);
                darkMusic.Play();
                rep = false;
            }
        }
        else 
        {
            light1.SetActive(true);
            light2.SetActive(true);
            sound.SetActive(true);
            darkMusic.Stop();
            rep = true;

        }
    }
    //Para coger la linterna.
    public void CatchLight()
    {
        linterna.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1.3f, player.transform.position.z);
        linterna.transform.parent = player.transform.GetChild(0).transform;
    }
    //Abre la puerta 4
    public void Open()
    {
        door4.transform.position = new Vector3(transform.position.x, 4f, transform.position.z);
    }
}

