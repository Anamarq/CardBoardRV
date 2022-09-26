using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speakers : MonoBehaviour
{
    //public GameManager gm;
    private int numSpeaker = 0;
    public int objetivoSpeakers=2;
    public GameObject door2;
    public AudioSource audiso;
    public GameObject sound;
    


    public void SpeakerSelected()
    {
        //Se traslada hasta que se llegue al número objetivo de speakers seleccionados
        if (numSpeaker < objetivoSpeakers)
        {
            transform.position = new Vector3(Random.Range(5f, 13f), Random.Range(0f, 3f), Random.Range(-5f, 5f));
        }
        else
        {
            //Se abre la puerta si se ha acertado todos los objetivos
            door2.transform.position = new Vector3(door2.transform.position.x, 4f, door2.transform.position.z);
            audiso.Stop();
            sound.SetActive(true);
        }
        ++numSpeaker;
    }
}
