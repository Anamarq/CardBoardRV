using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open1 : MonoBehaviour
{
    public GameObject cubo;
    public GameObject esfera;
    public GameObject capsula;
    public GameObject cilindro;
    public GameObject sound;
    public AudioSource audio2;
    private bool op = true;
    // Update is called once per frame
    
    void Start()
    {
        audio2.Stop();
    }
    void Update()
    {
        //Si las figuras son del color correcto se abre la puerta. op es para evitar repetir en bucle 
        //con op solo se ejecuta una vez
        if((cubo.GetComponent<MeshRenderer>().material.color == Color.yellow)
            && (esfera.GetComponent<MeshRenderer>().material.color == Color.green)
                && (capsula.GetComponent<MeshRenderer>().material.color == Color.red)
                && (cilindro.GetComponent<MeshRenderer>().material.color == Color.blue)&&op)
        {
            transform.position = new Vector3(transform.position.x, 4f, transform.position.z);
            sound.SetActive(false);
            audio2.Play();
            op = false;

        }
    }

}
